﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}