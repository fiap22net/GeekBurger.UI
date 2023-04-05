using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace GeekBurguer.UI.Model
{
    public class Order
    {
        
        public int orderId { get; set; }
        public string storeName { get; set; }
        public ICollection<Product> products { get; set; }
        = new List<Product>();
        public decimal total { get; set; }
    }
}
