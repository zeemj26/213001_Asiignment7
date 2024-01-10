using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class product : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public static List<Product> products = new List<Product>()
            {
            new Product() {productId = 1 , productName = "productOne" , price = 12000},
            new Product() {productId = 2 , productName = "producttwo" , price = 13000},
            new Product() {productId = 3 , productName = "productthree" , price = 15000},

};
        [
            HttpGet
        ]
        public List<Product> GetProducts()
        { return products; }
        [
            HttpPost
        ]
        public void PostProducts()
        {
            products.Add(new Product() { productId = 4, productName = "productfour", price = 16000 });
        }



        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
