using System;
using System.ComponentModel.DataAnnotations;

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
