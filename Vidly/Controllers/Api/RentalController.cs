using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalController()
        { 
            _context = new ApplicationDbContext();

        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {

            if (newRental.MovieId.Count == 0)
            {
                return BadRequest("No movies id has been given");
            }

            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId
                );

            if (customer==null)
            {
                return BadRequest("Customer ID is not valid");
            }


            var movies = _context.Movies.Where(m => newRental.MovieId.Contains(m.Id)).ToList();

            if (movies.Count != newRental.MovieId.Count)
            {
                return BadRequest("One or more Movie Id's are invalid");
            }

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                   return BadRequest("This movie is not availiable in stock");
                }

                movie.NumberAvailable--;

                
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

    }
}
