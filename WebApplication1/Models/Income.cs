using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Income
    {
        [Display(Name = "Сумма дохода")]
        public decimal Value { get; set; }

        [Display(Name = "Валюта")]
        public string Currency { get; set; }

    }
}