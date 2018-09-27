using System;
using System.ComponentModel.DataAnnotations;

namespace Archery.Validators
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Age : ValidationAttribute
    {
        public int MinimumAge { get; private set; }
        public int? MaxAge { get; set; }

        public Age(int minimumAge)
        {
            this.MinimumAge = minimumAge;
        }

        public Age(int minimumAge,int maxAge)
        {
            this.MinimumAge = minimumAge;
            this.MaxAge = maxAge;
        }



        public override bool IsValid(object value)
        {
            if (value is DateTime)
            {
                if (this.MaxAge == null)
                {
                return DateTime.Now.AddYears(-this.MinimumAge) >= (DateTime)value;
                }
                else
                {
                    return ((DateTime.Now.AddYears(-this.MinimumAge) >= (DateTime)value) && (DateTime.Now <= ((DateTime)value).AddYears((int)this.MaxAge)));
                }
            }
            else
            {
                throw new ArgumentException("Le type doit être un DateTime");
            }
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(this.ErrorMessage, name, MinimumAge,MaxAge);
        }
    }
}