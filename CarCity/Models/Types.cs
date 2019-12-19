using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Models
{
    public class Types
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "type")]
        public String name;
        //public List<Car> Car { get; set; }
    }
}
