using Inventory.Interface;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using Inventory.Repo;

namespace Inventory.Controllers
{
    public class ProductController : Controller
    {
        //private readonly IProductRepo _productRepo;

        private ProductDbContext db = new ProductDbContext();
       
        public ProductController()
        {
            
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }




        public JsonResult GetProduct()
        {
            //try
            //{
            //    //List<Product> products = new List<Product>();

            //    //Product p = new Product();
            //    //p.ProductName = "test";
            //    //p.Description = "ujyu";
            //    //p.Price = 10;
            //    //p.ProductCode = "122";
            //    //p.TypeId = 1;

            //    //products.Add(p);

            //    var products = _productRepo.GetProducts();                
            //    return Json(products, JsonRequestBehavior.AllowGet);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

            try
            {
                using (IProductRepo repo = new ProductRepo(db))
                {
                    //var products = repo.GetProducts().OrderByDescending(b=>b.Id);
                    var products = repo.GetProducts();
                    return Json(products, JsonRequestBehavior.AllowGet);

                }
            }
            catch (Exception e)
            {
                throw e;
            }



        }





        [HttpPost]
        public JsonResult SaveProduct(Product product)
        {

            try
            {
                using (IProductRepo repo = new ProductRepo(db))
                {
                    var data = repo.SaveProduct(product);
                    return Json(data);
                }
                //var data = _productRepo.SaveProduct(product);
                //return Json(data);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}