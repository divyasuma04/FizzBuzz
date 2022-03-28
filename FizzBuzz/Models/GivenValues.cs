using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FizzBuzz.Models
{
    public class GivenValues
    {
        [Required(ErrorMessage = "This field is required")]
        public string InputValues { get; set; }

        public string[] OutPutValues { get; set; }
    }
}