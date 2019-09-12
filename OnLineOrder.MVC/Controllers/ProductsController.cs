using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using OnLineOrder.MVC.DataModel;
using OnLineOrder.MVC.Dtos;
using OnLineOrder.MVC.OnLineOrderService;
using Product = OnLineOrder.Models.Product;

namespace OnLineOrder.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly OnLineOrderClient service;
        public ProductsController()
        {
            service = new OnLineOrderClient();
        }


        // GET: Products
        public ActionResult Index()
        {
            var result = service.CreateLoginSession("zi", "Password0");
            if (result.Errors.Count() == 0)
            {
                var products = service.GetAllAvailableProducts(result.OnLineOrderLoginSesssionKey);
                return View(MapServiceMVC.MapOnLineOrderRequest(products.GetAllProducts));
            }
            else
            {
                foreach (var errorMassage in result.Errors)
                {
                    ViewData["students"] = errorMassage.ErrorCode + " - " + errorMassage.ErrorDescription + "<br/>";
                }

                return View(ViewData["students"]);
            }
        }

        // GET: Products/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,ProductName,ProductDescription,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                var result = service.CreateLoginSession("Sazi", "Password0");
                OnLineOrderProductRequest products = new OnLineOrderProductRequest()
                {
                    ProductDescription = product.ProductDescription,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    SessionId = result.OnLineOrderLoginSesssionKey
                };
                service.CreateProduct(products);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = service.CreateLoginSession("Sazi", "Password0");

            var product = service.GetAvailableProductsByProductId(result.OnLineOrderLoginSesssionKey, id.Value);
            if (product.GetProduct == null)
            {
                ViewBag.Error = "Not Found";
                return HttpNotFound();
            }
            return View(MapServiceMVC.MapOnLineOrderRequestProduct(product.GetProduct));
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //  more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ProductId,ProductName,ProductDescription,Price")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(product).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(product);
        //}

        // GET: Products/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        //// POST: Products/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Product product = db.Products.Find(id);
        //    db.Products.Remove(product);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}


    }
}
