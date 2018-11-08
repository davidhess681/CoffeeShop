using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopWebApp.Models
{
    public class UserInfo
    {
        [Required] // attributes 
        [RegularExpression("^[A-Z]+[A-z]{1,30}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }

        /*[Required]
        [RegularExpression(@"^ ([a - zA - Z0 - 9_\-\.] +)@([a - zA - Z0 - 9_\-\.] +)\.([a - zA - Z]{2, 5})$")]*/
        public string Email { get; set; }

        public DateTime Birthday { get; set; }
        
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
        }
        public UserInfo(string fn, string ln, DateTime bd, string em)
        {
            FirstName = fn;
            LastName = ln;
            Birthday = bd;
            Email = em;
        }

    }
}