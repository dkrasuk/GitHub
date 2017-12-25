using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Collateral
    {
        public Guid ID { get; set; }

        [Display(Name = "Тип залога")]
        public string Type { get; set; }

        [Display(Name = "Описание залога")]
        public string Description { get; set; }

        [Display(Name = "Оценка залога")]
        public string Evaluation { get; set; }
    }
}