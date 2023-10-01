using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
