using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BB.AdvertisementApp.UI.Models
{
    public class UserCreateModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }
        public SelectList Genders { get; set; }

    }
}
