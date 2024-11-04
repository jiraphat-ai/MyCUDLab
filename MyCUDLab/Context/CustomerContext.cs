using MyCUDLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyCUDLab.Context
{
    public class CustomerContext : DbContext
    {
        public DbSet <Customer> Customer { get; set; }
    }
}