using System;
using System.ComponentModel.DataAnnotations;

namespace GeekBurguer.UI.Model
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string Face { get; set; }
        public string Restrictions { get; set; }
        public bool AreRestrictionsSet { get; set; }
    }
}
