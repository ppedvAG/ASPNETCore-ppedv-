using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Models
{

    /// <summary>
    /// Mit AttributeValidation kann man benutzerdefinierte Annotationen schreiben.
    /// </summary>
    public class LargerThanValidation : ValidationAttribute
    {
        int MinimumValue { get; set; }

        public LargerThanValidation(int MinimumValue)
        {
            this.MinimumValue = MinimumValue;
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            int? intValue = (int)value;

            if (!intValue.HasValue)
                return false;

            if (intValue < MinimumValue)
                return false;

            return true;
        }
    }
}
