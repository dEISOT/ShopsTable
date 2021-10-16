using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.Client.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ShopId { get; set; }

        public List<Shop> Shops { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }
    }
}
