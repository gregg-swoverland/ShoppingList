using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShoppingList.DataAccess;
using MyShoppingList.DataModels;

namespace MyShoppingList.Services
{
    public class MyShoppingListService
    {
        ApplicationDbContext db = new ApplicationDbContext();
        
        public MyShoppingListService()
        {

        }

        public List<ShoppingList> GetShoppingLists()
        {
            return db.ShoppingLists.ToList();
        }
    }
}
