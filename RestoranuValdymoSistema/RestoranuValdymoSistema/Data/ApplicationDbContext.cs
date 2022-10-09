using Microsoft.EntityFrameworkCore;
using RestoranuValdymoSistema.Data.Models;

namespace RestoranuValdymoSistema.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Note> Notes { get; set; }
    
    public ApplicationDbContext(DbContextOptions options) : base(options) { }


}