using System.ComponentModel.DataAnnotations;


namespace GeekBurguer.UI.Contract
{
    public class ItemToGet
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
    }
}
