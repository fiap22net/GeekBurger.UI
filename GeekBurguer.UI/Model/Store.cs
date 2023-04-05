using System;
using System.ComponentModel.DataAnnotations;

namespace GeekBurguer.UI.Model
{
    public class Store
    {
        [Key]
        public Guid StoreId { get; set; }
        public string Name { get; set; }
    }
}
