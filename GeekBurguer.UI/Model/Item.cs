using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekBurguer.UI.Model
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
