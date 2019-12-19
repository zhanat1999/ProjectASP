using CarCity.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Models
{
    public class Car : IValidatableObject
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Mark")]
        public string mark { get; set; }
        [Required]
        [Display(Name = "Year of Creation")]
        public string year { get; set; }
        [Required]
        [Display(Name = "Country")]
        [ValidCarCountry(allowedCountry: "Qazaqstan", ErrorMessage ="Only cars from Qazaqstan are accepted!!!")]
        public string country { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int result=0;
            try
            {
                result = Int32.Parse(year);
                
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{year}'");
            }
            if (result < 2000 )
            {
                yield return new ValidationResult(
                    $"It should be higher than 2000",
                    new[] { "year" });

            }
        }

        //public Year year { get; set; }
        //public Types type { get; set; }
        //public City city { get; set; }
        //public IList<CarOwner> CarOwners { get; set; }
    }
}
