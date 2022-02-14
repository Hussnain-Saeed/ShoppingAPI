using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingAPI.Models
{
    public class Role //Buyer, Seller, Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}