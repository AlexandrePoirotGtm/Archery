using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Archery.Validators
{
    public class IsUnique : ValidationAttribute
    {
        IEnumerable<object> List { get; set; }

       

        public override bool IsValid(object value)
        {
            foreach(object v in List)
            {
                if (v == value)
                    return true;
            }
            return false;
        }

    }
}