using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Address
    {
        [Display(Name = "Адресс регистрации")]
        public string RegistrationAddress { get; set; }

        [Display(Name = "Адресс проживания")]
        public string ResidentAddress { get; set; }

        [Display(Name = "Адреса совпадают?")]
        public bool IsEquals { get; set; }
    }
}