using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Archery.Models;
using Archery.Data;

namespace Archery.Validators
{
    public class EmailAttribute : ValidationAttribute
    {
        List<User> List { get; set; }
         
        public override bool IsValid(object value)
        {
            if(value != null && value is string)
            {
                using(ArcheryDbContext db = new ArcheryDbContext())
                {
                        return !db.Archers.Any(x => x.Mail == value.ToString());
                }
            }
            else
            {
                return true;
            }
            
        }

    }
}