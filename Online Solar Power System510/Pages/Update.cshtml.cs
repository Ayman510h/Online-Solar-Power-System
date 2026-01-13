using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Online_Solar_Power_System510.Data;
using Online_Solar_Power_System510.Models;

namespace Online_Solar_Power_System510.Pages
{
	public class UpdateModel : PageModel
	{
		private readonly AppDbContext _context;

		public UpdateModel(AppDbContext context)
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
			_context.Products.Update(Product);
			_context.SaveChanges();
			return RedirectToPage("Index");
		}
	}
}
