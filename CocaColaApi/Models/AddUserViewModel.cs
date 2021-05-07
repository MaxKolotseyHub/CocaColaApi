using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocaColaApi.Models
{
    public class AddUserViewModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

    }
}