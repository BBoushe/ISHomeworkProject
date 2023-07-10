using Microsoft.AspNetCore.Identity;

namespace Ticketopia.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public virtual ShoppingCart UserShoppingCart { get; set; }
    }
}
