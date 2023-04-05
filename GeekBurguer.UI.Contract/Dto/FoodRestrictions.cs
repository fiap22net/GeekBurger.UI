using GeekBurguer.UI.Contract;
using System.Collections.Generic;


namespace GeekBurguer.UI.Contract
{
    public class FoodRestrictions
    {
        public IList<ItemToGet> restrictions { get; set; }
        public string others { get; set; }
        public int userId { get; set; }
        public int requestId { get; set; }
        

    }
}
