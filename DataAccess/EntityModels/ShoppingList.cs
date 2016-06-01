﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyShoppingList.DataModels
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }

        [Column("UserId")]
        public int UserId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Color { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; }
    }
}