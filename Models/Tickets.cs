using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.ComponentModel.DataAnnotations;
using Ticketopia.Attributes;

namespace Ticketopia.Models
{
    public class Tickets
    {
        [Key]
        [Required]
        public int TicketId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }

        public string MovieImage { get; set; }

        [Required]
        [Range(0, 150, ErrorMessage = "Value should be between 0 and 150.")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, 300, ErrorMessage = "Value should be between 0 and 300 Euros.")]
        public float Price { get; set; }

        public DateTime ValidUntil { get; set; }

        [Required]
        [YearRange(1800, 2023, ErrorMessage = "The year must be between 1895 and the current year.")]
        public DateTime ReleaseDate { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public ICollection<ProductsInShoppingCart> ProductsInShoppingCart { get; set;}

    }
}

