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

        [Required]
        [RegularExpression(@"^([A-z0-9\.]{5,30})@([A-z]{5,10})\.([a-z]{2,3})$")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-?\d{3}-?\d{4}$")]
        public string PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        [RegularExpression(@"^[A-z0-9]{8,30}$")]
        public string Password { get; set; }
        
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
        }
        public UserInfo(string fn, string ln, DateTime bd, string pn, string em, string pw)
        {
            FirstName = fn;
            LastName = ln;
            Birthday = bd;
            PhoneNumber = pn;
            Email = em;
            Password = pw;
        }

    }
}