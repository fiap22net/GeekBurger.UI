using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurguer.UI.Contract
{
    public class Order
    {
        public int orderId { get; set; }
        public string storeName { get; set; }
        public decimal total { get; set; }
    }
}
