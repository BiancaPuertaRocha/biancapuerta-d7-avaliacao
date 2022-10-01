using Microsoft.EntityFrameworkCore;
using System;
using login_sys.Models;

namespace login_sys.Data;

public class Context : DbContext
{
	public Context(DbContextOptions<Context> options) : base(options)
	{
		Database.EnsureCreated();
	}

	public DbSet<User>? Users { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>(e =>
		{
			e.HasKey(m => m.Id);
			e.HasData(GetUsers());
		});
		base.OnModelCreating(modelBuilder);
	}

	private static User[] GetUsers()
	{
		return new User[]
		{
			new User
			{
				Id = 1,
				Login = "admin@email.com",
				Password = "admin123"
			},
		};
	}
}
