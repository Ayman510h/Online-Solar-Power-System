using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Online_Solar_Power_System510.Data;
using Online_Solar_Power_System510.Models;

namespace Online_Solar_Power_System510.Pages
{
	public class InsertModel : PageModel
	{
		private readonly AppDbContext _context;

		public InsertModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Product Product { get; set; }

		public void OnGet() { }

		public IActionResult OnPost()
		{
			_context.Products.Add(Product);
			_context.SaveChanges();
			return RedirectToPage("Index");
		}
	}
}
