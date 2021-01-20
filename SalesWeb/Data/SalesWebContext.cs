using Microsoft.EntityFrameworkCore;

namespace SalesWeb.Models
{
	public class SalesWebContext : DbContext
	{
		public SalesWebContext(DbContextOptions<SalesWebContext> options)
			: base(options)
		{
		}

		public DbSet<Department> Department { get; set; }
		public DbSet<Seller> Seller { get; set; }
		public DbSet<SalesRecord> SalesRecord { get; set; }
	}
}
