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
    public class DetailsModel : PageModel
    {
        private readonly ContosoCrafts.Data.ProductContext _context;

        public DetailsModel(ContosoCrafts.Data.ProductContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.Key == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
