using System.ComponentModel.DataAnnotations;

namespace Ticketopia.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public string AppUserID { get; set; }
        public ICollection<ProductsInShoppingCart> ProductsInShoppingCart { get; set; }
    }
}
