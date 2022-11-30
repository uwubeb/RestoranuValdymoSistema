using Microsoft.EntityFrameworkCore;
using RestoranuValdymoSistema.Data.Models;
using RestoranuValdymoSistema.Infrastructure;
using RestoranuValdymoSistema.Services;

namespace RestoranuValdymoSistema.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        modelBuilder.Entity<Restaurant>().Navigation(r => r.Orders).AutoInclude();
        //modelBuilder.Entity<Order>().Navigation(o => o.Restaurant).AutoInclude();

        var data = new DbInitializer();

        modelBuilder.Entity<Restaurant>().HasData(data.Restaurants);
        modelBuilder.Entity<Order>().HasData(data.Orders);
        modelBuilder.Entity<Note>().HasData(data.Notes);
        //var users = new List<User>();
        //var usersRequests = data.UserRequests;

        //foreach (var request in usersRequests)
        //{
        //    var user = _authService.Register(request).Result;
        //    users.Add(user);
        //}
        //modelBuilder.Entity<User>().HasData(users);




    }

}