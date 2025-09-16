using ChoiceHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChoiceHub.Infrastructure.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		DbSet<Empresa> Empresas { get; set; }
	}
}
