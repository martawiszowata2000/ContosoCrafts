using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoCrafts.Data;
using ContosoCrafts.Models;

namespace ContosoCrafts.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ContosoCrafts.Data.ProductContext _context;

        public IndexModel(ContosoCrafts.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
