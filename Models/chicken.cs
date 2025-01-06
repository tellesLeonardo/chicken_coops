using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Galinheiro.Models;

namespace Galinheiro.Models
{
    [Table("chicken")]
    public class Chicken
    {
        [Key]
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Name { get; set; }
        public string? Photo { get; set; }
        public bool Vaccinated { get; set; }
        public int StatusId { get; set; }

        [ForeignKey("status_id")] // Defina a chave estrangeira explicitamente
        public required ChickenStatus Status { get; set; }

        public ICollection<Egg>? Eggs { get; set; }



    }
}