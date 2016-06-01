using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyShoppingList.DataModels
{
    public class ShoppingListItem
    {
        [Key]
        public int Id { get; set; }

        [Column("ShoppingListId")]
        public int UserId { get; set; }

        public String Contents { get; set; }

        public int Priority { get; set; }

        public bool IsChecked { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; }
    }
}