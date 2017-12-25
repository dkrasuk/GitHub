using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebApplication1.Models
{
    public class ApplicationViewModel
    {
        public Guid Id { get; set; }

        public Client Client { get; set; }

        public Address Address { get; set; }
        
        public Income Income { get; set; }

        [Display(Name = "Залоги")]
        public List<Collateral> Collaterals { get; set; }
        [Display(Name = "Комментарий")]
        public string Comment { get; set; }

        public ApplicationViewModel()
        {
                Collaterals = new List<Collateral>();
        }
    }
}