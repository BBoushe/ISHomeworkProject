using System.ComponentModel.DataAnnotations.Schema;

namespace Ticketopia.Models
{
    public class ProductsInShoppingCart        
    {
        public int TicketID { get; set; }

        public int CartID { get; set; }

        [ForeignKey("TicketID")]
        public Tickets Tickets { get; set; }

        [ForeignKey("CardID")]
        public ShoppingCart ShoppingCart { get; set; }
    }
}
