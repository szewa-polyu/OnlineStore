using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class StoreController : Controller
    {
        private OnlineStoreEntities storeDb = new OnlineStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            IEnumerable<Category> categories = storeDb.Categories.ToArray();
            return View(categories);
        }
        
        // GET: Store/Browse?category=Food
        public string Browse(string category)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
                + category);

            return message;
        }
        
        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            Product product = new Product
            {
                Name = "Product " + id
            };
            return View(product);
        }
    }
}