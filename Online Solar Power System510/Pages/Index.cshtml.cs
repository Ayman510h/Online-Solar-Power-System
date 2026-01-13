using Microsoft.AspNetCore.Mvc.RazorPages;
using Online_Solar_Power_System510.Data;
using Online_Solar_Power_System510.Models;
using System.Collections.Generic;
using System.Linq;

namespace Online_Solar_Power_System510.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        
        public IList<Product> Products { get; set; }

        public void OnGet()
        {
           
            Products = _context.Products.ToList();
        }
    }
}
