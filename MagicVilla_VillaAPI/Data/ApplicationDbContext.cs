using System;
using Microsoft.EntityFrameworkCore;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Data
{
	public class ApplicationDbContext
	{
		public DbSet<Villa> Villas { get; set; }
	}
}

