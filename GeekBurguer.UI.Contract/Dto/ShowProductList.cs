
using System.Collections.Generic;


namespace GeekBurguer.UI.Contract
{
    public class ShowProductList
    {
        public IList<ProductToGet> Products { get; set; }
    }
}
