using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiTeste.Models;

namespace WebApiTeste.Context
{
	public class ApplicationDbContext: DbContext
    {

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
			this.Database.EnsureCreated();
		}


		public DbSet<Product> Products { get; set; }
    }
}
