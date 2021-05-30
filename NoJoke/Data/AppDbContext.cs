using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoJoke.Data
{
	public class AppDbContext : IdentityDbContext
	{
		private readonly DbContextOptions _options;

		public AppDbContext(DbContextOptions options) : base(options)
		{
			_options = options;
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
