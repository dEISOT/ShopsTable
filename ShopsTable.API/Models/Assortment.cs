using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsTable.API.Models
{
    public class Assortment
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ShopId { get; set; }
        public Guid ItemId { get; set; }
    }
}
