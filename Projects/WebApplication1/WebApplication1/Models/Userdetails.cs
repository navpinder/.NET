using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.LocalResource;

namespace WebApplication1.Models
{
    public class Userdetails
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resource))]
        public string LastName { get; set; }
    }
}