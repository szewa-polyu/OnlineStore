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
        public ActionResult Browse(string category)
        {
            // Retrieve Categories and its Associated Products from database
            Category categoryModel = storeDb.Categories.Include("Products")
                .Single(c => c.Name == category);

            return View(categoryModel);
        }
        
        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            Product product = storeDb.Products.Find(id);
            return View(product);
        }
    }
}