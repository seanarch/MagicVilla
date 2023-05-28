using System;
using Microsoft.EntityFrameworkCore;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Villa> Villas { get; set; }
	}
}

