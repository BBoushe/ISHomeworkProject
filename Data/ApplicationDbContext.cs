using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ticketopia.Models;

namespace Ticketopia.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ProductsInShoppingCart> ProductsInShoppingCarts { get; set; }

        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ProductsInShoppingCart>().HasKey(c => new { c.CartID, c.TicketID });
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}