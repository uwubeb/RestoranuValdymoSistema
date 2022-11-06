using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RestoranuValdymoSistema;
using RestoranuValdymoSistema.Data;
using RestoranuValdymoSistema.Data.Models;
using RestoranuValdymoSistema.Infrastructure.Repositories;
using RestoranuValdymoSistema.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services
    .AddScoped(typeof(IRepository<>), typeof(BaseRepository<>))
    .AddScoped<INoteRepository, NoteRepository>()
    .AddScoped<IOrderRepository, OrderRepository>();

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
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlerMiddleware>();


// Restaurants
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
    await repo.Update(restaurant);

    return Results.NoContent();
});

app.MapDelete("/restaurants/{id}", async (Guid id, IRepository<Restaurant> repo) =>
{
    if (await repo.GetById(id) is not { } restaurant) return Results.NotFound();

    await repo.Delete(restaurant);

    return Results.NoContent();

});

// Orders
app.MapGet("/restaurants/{restaurantId}/orders",
    async (IOrderRepository repo, Guid restaurantId) => Results.Ok(await repo.Get(restaurantId)));

app.MapGet("/restaurants/{restaurantId}/orders/{orderId}",
    async (Guid orderId, Guid restaurantId, IOrderRepository repo) => Results.Ok(await repo.Get(restaurantId, orderId)));
  
app.MapPost("/restaurants/{restaurantId}/orders", async (Order order, Guid restaurantId, IOrderRepository repo) =>
{
    await repo.Create(restaurantId, order);
    return Results.Ok(order);
});

app.MapPut("/restaurants/{restaurantId}/orders", async (Order order, Guid restaurantId, IOrderRepository repo) =>
{
    await repo.Update(restaurantId, order);
    return Results.NoContent();
});

app.MapDelete("/restaurants/{restaurantId}/orders/{orderId}", async (Guid orderId, Guid restaurantId, IOrderRepository repo) =>
{

    await repo.Delete(restaurantId,orderId);

    return Results.NoContent();
});

// Notes
app.MapGet("/restaurants/{restaurantId}/orders/{orderId}/notes",
    async (INoteRepository repo, Guid restaurantId, Guid orderId) =>
{
    var notes = await repo.Get(restaurantId, orderId);
    return Results.Ok(notes);
});

app.MapGet("/restaurants/{restaurantId}/orders/{orderId}/notes/{noteId}", async (Guid noteId, Guid restaurantId, Guid orderId, INoteRepository repo) =>
{
    var note = await repo.Get(restaurantId, orderId, noteId);
    return Results.Ok(note);
});

app.MapPost("/restaurants/{restaurantId}/orders/{orderId}/notes", async (Note note, Guid restaurantId, Guid orderId, INoteRepository repo) =>
{
    await repo.Create(restaurantId, orderId, note);

    return Results.Ok(note);
});

app.MapPut("/restaurants/{restaurantId}/orders/{orderId}/notes", async (Note note, Guid restaurantId, Guid orderId, INoteRepository repo) =>
{

    await repo.Update(restaurantId, orderId, note);

    return Results.NoContent();
});

app.MapDelete("/restaurants/{restaurantId}/orders/{orderId}/notes/{noteId}", async (Guid noteId, Guid restaurantId, Guid orderId, INoteRepository repo) =>
{
    await repo.Delete(restaurantId, orderId, noteId);
    return Results.NoContent();
});

//// Employees
//app.MapGet("/restaurants/employees", async (IRepository<Employee> repo) =>
//    await repo.GetAll());

//app.MapGet("/restaurants/employees/{id}", async (Guid id, IRepository<Employee> repo) =>
//    await repo.GetById(id)
//        is { } employee
//        ? Results.Ok(employee)
//        : Results.NotFound());

//app.MapPost("/restaurants/employees", async (Employee employee, IRepository<Employee> repo) =>
//    {
//        await repo.Create(employee);

//        return Results.Created($"/employees/{employee.Id}", employee);
//    });

//app.MapPut("/restaurants/employees", async (Employee employee, IRepository<Employee> repo) =>
//    {
//        await repo.Update(employee);

//        return Results.NoContent();
//    });

//app.MapDelete("/restaurants/employees/{id}", async (Guid id, IRepository<Employee> repo) =>
//    {
//        if (await repo.GetById(id) is not { } employee) return Results.NotFound();

//        await repo.Delete(employee);

//        return Results.Ok(employee);

//    });





app.Run();