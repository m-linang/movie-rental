using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.ViewModels
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movies Movies { get; set; }
        public string Title
        {
            get
            {
                if (Movies != null && Movies.Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}