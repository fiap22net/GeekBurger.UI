using System.Collections.Generic;

namespace GeekBurguer.UI.Contract
{ 
    public class OrderToGet
    {
        public int orderId { get; set; }
        public string storeName { get; set; }
        public IList<ProductToInsert> product { get; set; }
        public IList<int> productionId { get; set; }

    }
}
