using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleCRUD.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public string Phone { get; set; }
        public Customer()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }

}