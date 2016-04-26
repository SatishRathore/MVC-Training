using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataValidation.Models
{
    //claas name should contain Attribute as suffix
    public class FullNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value) 
        { 
            var nameComponents = value.ToString().Split(' ');
            if (nameComponents.Length == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}