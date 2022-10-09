using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RestoranuValdymoSistema.Data;
using RestoranuValdymoSistema.Data.Models;
using RestoranuValdymoSistema.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

var connectionStringKey = "DefaultConnection";
var connectionString = builder.Configuration.GetConnectionString(connectionStringKey);


builder.Services.AddDbContext<ApplicationDbContext>(opts =>
{
    opts.UseNpgsql(connectionString);
});

builder.Services
    .BuildServiceProvider()
    .GetService<ApplicationDbContext>()?
    .Database.Migrate();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGet("/", () => "Hello World!");

app.MapGet("/restaurants", async (ApplicationDbContext db) =>
    await db.Restaurants.ToListAsync());

app.MapGet("/restaurants/{id}", async (Guid id, ApplicationDbContext db) =>
    await db.Restaurants.FindAsync(id)
        is Restaurant restaurant
        ? Results.Ok(restaurant)
        : Results.NotFound());

app.MapPost("/restaurants", async (Restaurant restaurant, ApplicationDbContext db) =>
{
    db.Restaurants.Add(restaurant);
    await db.SaveChangesAsync();

    return Results.Created($"/restaurants/{restaurant.Id}", restaurant);
});

app.MapPut("/restaurants/{id}", async (Guid id, Restaurant inputRestaurant, ApplicationDbContext db) =>
{
    var restaurant = await db.Restaurants.FindAsync(id);

    if (restaurant is null) return Results.NotFound();

    restaurant.Name = inputRestaurant.Name;
    restaurant.Address = inputRestaurant.Address;
    restaurant.Email = inputRestaurant.Email;
    restaurant.PhoneNumber = inputRestaurant.PhoneNumber;
    restaurant.Employees = inputRestaurant.Employees;
    restaurant.Orders = inputRestaurant.Orders;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/restaurants/{id}", async (Guid id, ApplicationDbContext db) =>
{
    if (await db.Restaurants.FindAsync(id) is not Restaurant restaurant) return Results.NotFound();
    db.Restaurants.Remove(restaurant);
    await db.SaveChangesAsync();
    return Results.Ok(restaurant);

});



app.Run();
