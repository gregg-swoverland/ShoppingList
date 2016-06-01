using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShoppingList.ViewModels
{
    public class AddListViewModel
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Color { get; set; }
    }
}