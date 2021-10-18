using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopsTable.API.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }

        public List<Shop> Shops { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }
    }
}
