using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShoppingCartTrial.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
           GetMenus();
                return View();
        }

        public static List<Menu> GetMenus()
        {
            using (var context = new MyCartDBEntities())
            {
                return context.Menus.ToList();
            }
        }
    }
}