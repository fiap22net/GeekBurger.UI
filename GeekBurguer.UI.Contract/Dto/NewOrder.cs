using System.Collections.Generic;
using GeekBurguer.UI.Contract;

namespace GeekBurguer.UI.Contract
{
    public class NewOrder
    {
        public int orderId { get; set; }
        public string storeName { get; set; }
        public decimal total { get; set; }
        public IList<ProductToGet> products { get; set; }
        public IList<int> productionId { get; set; }
    }
}
