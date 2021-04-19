using ContosoCrafts.Data;
using ContosoCrafts.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        private readonly ProductContext _context;
        public IEnumerable<Product> Products { get; private set; }
        public IList<Product> Productsdb { get; set; }
        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService, ProductContext context)
        {
            _logger = logger;
            _context = context;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
            Productsdb = _context.Product.ToList();

        }

    }
}
