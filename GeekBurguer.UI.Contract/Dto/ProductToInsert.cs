using System.ComponentModel.DataAnnotations;

namespace GeekBurguer.UI.Contract
{
    public class ProductToInsert
    {
        [Key]
        public string ProductId { get; set; }
        public decimal price { get; set; }
    }
}
