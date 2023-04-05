using System.ComponentModel.DataAnnotations;

namespace GeekBurguer.UI.Contract
{
    public class ProductToGet
    {
        [Key]
        public string ProductId { get; set; }
       
    }
}
