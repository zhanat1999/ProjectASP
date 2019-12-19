using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Models
{
    public class CarOwner
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        //public int CarId { get; set; }
        //public Car Car { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
