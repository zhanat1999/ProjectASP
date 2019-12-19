using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Models
{
    public class Owner
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "firstName")]
        public string firstName { get; set; }
        [Display(Name = "lastName")]
        public string lastName { get; set; }
        [Display(Name = "Birthday")]
        public DateTime birthday { get; set; }

        public IList<CarOwner> CarOwners { get; set; }
    }
}
