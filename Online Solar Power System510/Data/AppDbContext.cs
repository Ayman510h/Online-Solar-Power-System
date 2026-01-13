using Microsoft.EntityFrameworkCore;
using Online_Solar_Power_System510.Models;

namespace Online_Solar_Power_System510.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
	}
}
