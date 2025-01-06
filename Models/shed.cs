using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Galinheiro.Models;

namespace Galinheiro.Models
{
    [Table("shed")]
    public class Shed
    {
        [Key]
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? Postcode { get; set; }
        public int CurrentChickensCount { get; set; }
        public int MaxChickensCapacity { get; set; }

        public ICollection<Feed>? Feeds { get; set; }

    }
}