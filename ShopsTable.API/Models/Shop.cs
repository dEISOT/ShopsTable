﻿using System;
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

        public string Adress { get; set; }

        public string WorkTime { get; set; }

        public string Name { get; set; }
    }
}
