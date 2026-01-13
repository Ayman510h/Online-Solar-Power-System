using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Online_Solar_Power_System510.Data;
using Online_Solar_Power_System510.Models;

namespace Online_Solar_Power_System510.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public void OnGet(int id)
        {
            Product = _context.Products.Find(id);
        }

        public IActionResult OnPost()
        {
            var product = _context.Products.Find(Product.Id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToPage("Index");
        }
    }
}
