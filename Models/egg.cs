using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Galinheiro.Models;

namespace Galinheiro.Models
{
    [Table("egg")]
    public class Egg
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public int ChickenId { get; set; }

        [ForeignKey("chicken_id")] // Defina a chave estrangeira explicitamente// Chave estrangeira para Galinha
        public required Chicken Chicken { get; set; }
    }
}