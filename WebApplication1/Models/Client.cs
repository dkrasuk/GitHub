using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Client
    {
        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "ИНН")]
        public string INN { get; set; }
    }
}