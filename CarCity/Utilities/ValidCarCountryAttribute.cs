using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Utilities
{
    public class ValidCarCountryAttribute : ValidationAttribute
    {
        private readonly string allowedCountry;

        public ValidCarCountryAttribute(string allowedCountry)
        {
            this.allowedCountry = allowedCountry;
        }

        public override bool IsValid(object value)
        {
            string a_name = value.ToString();
            return a_name.ToUpper() == allowedCountry.ToUpper();
        }
    }
}
