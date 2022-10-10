using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
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

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/restaurants", async (IRepository<Restaurant> repo) =>
    await repo.GetAll());

app.MapGet("/restaurants/{id}", async (Guid id, IRepository<Restaurant> repo) =>
    await repo.GetById(id)
        is { } restaurant
        ? Results.Ok(restaurant)
        : Results.NotFound());

app.MapPost("/restaurants", async (Restaurant restaurant, IRepository<Restaurant> repo) =>
{
    await repo.Create(restaurant);

    return Results.Created($"/restaurants/{restaurant.Id}", restaurant);
});

app.MapPut("/restaurants", async (Restaurant restaurant, IRepository<Restaurant> repo) =>
{
    repo.Update(restaurant);

    return Results.NoContent();
});

app.MapDelete("/restaurants/{id}", async (Guid id, IRepository<Restaurant> repo) =>
{
    if (await repo.GetById(id) is not { } restaurant) return Results.NotFound();

    repo.Delete(restaurant);

    return Results.Ok(restaurant);

});

app.MapGet("/orders", async (IRepository<Order> repo) =>
    await repo.GetAll());

app.MapGet("/orders/{id}", async (Guid id, IRepository<Order> repo) =>
    await repo.GetById(id)
        is { } order
        ? Results.Ok(order)
        : Results.NotFound());

app.MapPost("/orders", async (Order order, IRepository<Order> repo) =>
{
    await repo.Create(order);

    return Results.Created($"/orders/{order.Id}", order);
});

app.MapPut("/orders", async (Order order, IRepository<Order> repo) =>
{
    repo.Update(order);

    return Results.NoContent();
});

app.MapDelete("/orders/{id}", async (Guid id, IRepository<Order> repo) =>
{
    if (await repo.GetById(id) is not { } order) return Results.NotFound();

    repo.Delete(order);

    return Results.Ok(order);

});


app.Run();
