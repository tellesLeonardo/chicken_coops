using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Galinheiro.Models;

namespace Galinheiro.Models
{
    [Table("chicken_status")]
    public class ChickenStatus
    {
        [Key]
        public int Id { get; set; }
        public string? Chick { get; set; }
        public string? Rebreeder1 { get; set; }
        public string? Rebreeder2 { get; set; }
        public string? PreLaying { get; set; }
        public string? Production { get; set; }

        // Relacionamento com Galinhas
        public ICollection<Chicken>? Chickens { get; set; }




    }

}