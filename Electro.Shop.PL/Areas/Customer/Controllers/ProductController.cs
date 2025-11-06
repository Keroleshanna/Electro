using Electro.Shop.BLL.DTOs.Products;
using Electro.Shop.BLL.Services.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Electro.Shop.PL.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController(IProductService productService) : Controller
    {
        private readonly IProductService _productService = productService;

        // GET: ProductController
        public async Task<ActionResult> Index()
        {
            var products = (await _productService.GetAllAsync()).AsQueryable()
                .Include(p => p.ProductImages)
                .Include(s => s.SubCategory)
                .ThenInclude(c => c.Category).ToList();

            
            foreach(var item in products)
            {
                
            }

            // .Select(p => new ProductDto
            // {
            //     Id = p.Id,
            //     Name = p.Name,
            //     Price = p.Price,
            //     Description = p.Description,
            //     Images = p.ProductImages.Select(img => new ProductImageDto
            //     {
            //         ImageUrl = img.ImageUrl,
            //         IsMain = img.IsMain
            //     }).ToList(),
            //     SubCategoryName = p.SubCategory.Name,
            //     CategoryName = p.SubCategory.Category.Name
            // }).ToList();

            return Ok(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
