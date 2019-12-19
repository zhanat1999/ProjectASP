using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Models
{
    public class City
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "city")]
        public string name { get; set; }
        //public List<Car> Car { get; set; } 
    }
}
