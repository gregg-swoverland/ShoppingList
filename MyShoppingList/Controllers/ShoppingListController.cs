using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MyShoppingList.ViewModels;
using MyShoppingList.DataAccess;
using MyShoppingList.Services;

namespace MyShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        MyShoppingListService _service = new MyShoppingListService();

        // GET: ShoppingList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyLists()
        {
            var lists = _service.GetShoppingLists();
            return View(lists);
        }

        // GET: AddList
        [HttpGet]
        public ActionResult AddList()
        {
            var vm = new AddListViewModel();

            return View(vm);
        }


    }
}