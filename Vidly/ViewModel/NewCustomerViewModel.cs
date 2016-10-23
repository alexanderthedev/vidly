﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipTypes> MembershipTypes { get; set; }
        public Customer customer { get; set; }
    }
}