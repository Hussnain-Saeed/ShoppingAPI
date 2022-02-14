using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public DateTime AddedOn { get; set; }
        public virtual ProductStatus ProductStatus { get; set; }
        public int ProductStatusId { get; set; }
    }
}