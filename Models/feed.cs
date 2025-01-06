using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Galinheiro.Models;

namespace Galinheiro.Models
{
    [Table("feed")]
    public class Feed
    {
        [Key]
        public int Id { get; set; }
        public string? FeedType { get; set; }
        public int QuantityKg { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int ShedId { get; set; }

        // Chave estrangeira para Galpão (Shed)
        public required Shed Shed { get; set; }
    }

}