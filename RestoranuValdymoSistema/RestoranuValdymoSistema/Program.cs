using System.Text.Json.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RestoranuValdymoSistema;
using RestoranuValdymoSistema.Data;
using RestoranuValdymoSistema.Data.Contracts.Note;
using RestoranuValdymoSistema.Data.Contracts.Order;
using RestoranuValdymoSistema.Data.Contracts.Restaurant;
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
    .AddScoped<IOrderRepository, OrderRepository>()
    .AddScoped<IRestaurantRepository, RestaurantRepository>();

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
app.MapGet("/restaurants", async (IRestaurantRepository repo, IMapper mapper) =>
{
    List<RestaurantContract> restaurantContracts = mapper.Map<List<RestaurantContract>>(await repo.Get());
    return Results.Ok(restaurantContracts);
});

app.MapGet("/restaurants/{id}", async (Guid id, IRestaurantRepository repo, IMapper mapper) =>
{
    var restaurant = await repo.Get(id);
    var restaurantContract = mapper.Map<RestaurantContract>(restaurant);
    return Results.Ok(restaurantContract);
});

app.MapPost("/restaurants", async (CreateRestaurantContract createRestaurantContract, IRepository<Restaurant> repo, IMapper mapper ) =>
{
    var restaurant = mapper.Map<Restaurant>(createRestaurantContract);
    await repo.Create(restaurant);
    var restaurantContract = mapper.Map<RestaurantContract>(restaurant);
    
    return Results.Created($"/restaurants/{restaurantContract.Id}", restaurantContract);
});

app.MapPut("/restaurants", async (UpdateRestaurantContract restaurantContract, IRestaurantRepository repo, IMapper mapper) =>
{
    var restaurant = mapper.Map<Restaurant>(restaurantContract);
    await repo.Update(restaurant);

    return Results.NoContent();
});

app.MapDelete("/restaurants/{id}", async (Guid id, IRestaurantRepository repo) =>
{
    await repo.Delete(id);

    return Results.NoContent();

});

// Orders
app.MapGet("/restaurants/{restaurantId}/orders",
    async (IOrderRepository repo, Guid restaurantId, IMapper mapper) =>
{
    var orders = await repo.Get(restaurantId);
    var orderContracts = mapper.Map<List<OrderContract>>(orders);
    return Results.Ok(orderContracts);
});

app.MapGet("/restaurants/{restaurantId}/orders/{orderId}",
    async (Guid orderId, Guid restaurantId, IOrderRepository repo, IMapper mapper) =>
{
    var order = await repo.Get(restaurantId, orderId);
    var orderContract = mapper.Map<OrderContract>(order);
    return Results.Ok(orderContract);
});

app.MapPost("/restaurants/{restaurantId}/orders", async (CreateOrderContract orderContract, Guid restaurantId, IOrderRepository repo, IMapper mapper) =>
{
    var order = mapper.Map<Order>(orderContract);
    await repo.Create(restaurantId, order);
    var orderContractResult = mapper.Map<OrderContract>(order);
    return Results.Created($"/restaurants/{restaurantId}/orders/{orderContractResult.Id}", orderContractResult);
});

app.MapPut("/restaurants/{restaurantId}/orders", async (UpdateOrderContract orderContract, Guid restaurantId, IOrderRepository repo, IMapper mapper) =>
{
    var order = mapper.Map<Order>(orderContract);
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
    async (INoteRepository repo, Guid restaurantId, Guid orderId, IMapper mapper) =>
{
    var notes = await repo.Get(restaurantId, orderId);
    var noteContracts = mapper.Map<List<NoteContract>>(notes);
    return Results.Ok(noteContracts);
});

app.MapGet("/restaurants/{restaurantId}/orders/{orderId}/notes/{noteId}", async (Guid noteId, Guid restaurantId, Guid orderId, INoteRepository repo, IMapper mapper) =>
{
    var note = await repo.Get(restaurantId, orderId, noteId);
    var noteContract = mapper.Map<NoteContract>(note);
    return Results.Ok(noteContract);
});

app.MapPost("/restaurants/{restaurantId}/orders/{orderId}/notes", async (CreateNoteContract noteContract, Guid restaurantId, Guid orderId, INoteRepository repo, IMapper mapper) =>
{
    var note = mapper.Map<Note>(noteContract);
    await repo.Create(restaurantId, orderId, note);
    var noteContractResult = mapper.Map<NoteContract>(note);
    return Results.Created($"/restaurants/{restaurantId}/orders/{orderId}/notes/{noteContractResult.Id}", noteContractResult);
});

app.MapPut("/restaurants/{restaurantId}/orders/{orderId}/notes", async (UpdateNoteContract noteContract, Guid restaurantId, Guid orderId, INoteRepository repo, IMapper mapper) =>
{
    var note = mapper.Map<Note>(noteContract);
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
