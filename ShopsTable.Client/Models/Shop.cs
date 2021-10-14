using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.Client.Models
{
    public class Shop
    {
        [Key]
        public Guid Id { get; set; }

        public List<Item> Items { get; set; }

        public string Adress { get; set; }

        public string WorkTime { get; set; }

        public string Name { get; set; }
    }
}
