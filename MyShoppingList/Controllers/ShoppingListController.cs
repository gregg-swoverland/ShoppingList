using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MyShoppingList.DataModels;
using MyShoppingList.DataAccess;

namespace MyShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyLists()
        {
            var lists = db.ShoppingLists.ToList();
            return View(lists);
        }
    }
}