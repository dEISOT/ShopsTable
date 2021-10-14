using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Models
{
    public class Shop
    {
        [Key]
        public Guid Id { get; set; }

        public List<Item> Items{ get; set; }

        public double Price { get; set; }

        public string imgBase64 { get; set; }
    }
}
