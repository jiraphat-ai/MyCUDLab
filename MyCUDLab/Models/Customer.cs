using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyCUDLab.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}