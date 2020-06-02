﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaristaBuddyApi.Models.DTO
{
    public class StoreDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]

        public string City { get; set; }

        [Required]
        public string state { get; set; }
        [Required]

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string WebSiteUrl { get; set; }

        public string StoreImageUrl { get; set; }

        //public List <StoreItemDTO> items { get; set; }
    }
}
