using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleCRUD.Models
{
    public class CRUContext : DbContext
    {
        public CRUContext()
            :base("SimpleCrudConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}