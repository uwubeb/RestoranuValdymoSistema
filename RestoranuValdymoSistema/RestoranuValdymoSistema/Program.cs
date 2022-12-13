using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RestoranuValdymoSistema;
using RestoranuValdymoSistema.Data;
using RestoranuValdymoSistema.Data.Constants;
using RestoranuValdymoSistema.Data.Contracts.Note;
using RestoranuValdymoSistema.Data.Contracts.Order;
using RestoranuValdymoSistema.Data.Contracts.Restaurant;
using RestoranuValdymoSistema.Data.Contracts.User;
using RestoranuValdymoSistema.Data.Models;
using RestoranuValdymoSistema.Infrastructure;
using RestoranuValdymoSistema.Infrastructure.Repositories;
using RestoranuValdymoSistema.Middleware;
using RestoranuValdymoSistema.Services;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddAuthorization();
builder.Services.AddCors(options => options.AddPolicy(name: "NgOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services
    .AddScoped(typeof(IRepository<>), typeof(BaseRepository<>))
    .AddScoped<INoteRepository, NoteRepository>()
    .AddScoped<IOrderRepository, OrderRepository>()
    .AddScoped<IRestaurantRepository, RestaurantRepository>()
    .AddScoped<IAuthService, AuthService>()
    .AddHttpContextAccessor();

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

var corsOrigins = app.Configuration.GetValue<string>("CORSOrigins").Split(",");
if (corsOrigins.Any())
{
    app.UseCors(builder => builder
        .WithOrigins(corsOrigins)
        .AllowAnyHeader()
        .AllowAnyMethod());
}


app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ErrorHandlerMiddleware>();


// Restaurants
app.MapGet("/restaurants", [AllowAnonymous] async (IRestaurantRepository repo, IMapper mapper, IHttpContextAccessor context) =>
{
    var userClaims = context.HttpContext.User.Claims;
    //var userClaims = new List<Claim> { new Claim(ClaimTypes.Role, "superadmin") };
    List<RestaurantContract> restaurantContracts;
    if (userClaims.First(x => x.Type == ClaimTypes.Role).Value == "superadmin")
    {
        restaurantContracts = mapper.Map<List<RestaurantContract>>(await repo.Get());
        return Results.Ok(restaurantContracts);
    }

    var userId = userClaims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
    restaurantContracts = mapper.Map<List<RestaurantContract>>(await repo.GetByUserId(Guid.Parse(userId)));
    return Results.Ok(restaurantContracts);
});

app.MapGet("/restaurantList", [AllowAnonymous] async (IRestaurantRepository repo, IMapper mapper) =>
{
    var restaurantContracts = mapper.Map<List<RestaurantContract>>(await repo.Get());
    return Results.Ok(restaurantContracts);
});

app.MapGet("/restaurants/{id}", [Authorize(Roles = "user, admin, superadmin")] async (Guid id, IRestaurantRepository repo, IMapper mapper) =>
{
    // check role from token
    
    var restaurant = await repo.Get(id);
    var restaurantContract = mapper.Map<RestaurantContract>(restaurant);
    return Results.Ok(restaurantContract);
});

app.MapPost("/restaurants", [Authorize(Roles = "admin, superadmin")] async (CreateRestaurantContract createRestaurantContract, IRepository<Restaurant> repo, IMapper mapper ) =>
{
    var restaurant = mapper.Map<Restaurant>(createRestaurantContract);
    await repo.Create(restaurant);
    var restaurantContract = mapper.Map<RestaurantContract>(restaurant);
    
    return Results.Created($"/restaurants/{restaurantContract.Id}", restaurantContract);
});

app.MapPut("/restaurants", [Authorize(Roles = "admin, superadmin")] async (UpdateRestaurantContract restaurantContract, IRestaurantRepository repo, IMapper mapper) =>
{
    var restaurant = mapper.Map<Restaurant>(restaurantContract);
    await repo.Update(restaurant);

    return Results.NoContent();
});

app.MapDelete("/restaurants/{id}", [Authorize(Roles = "admin, superadmin")] async (Guid id, IRestaurantRepository repo) =>
{
    await repo.Delete(id);

    return Results.NoContent();

});

// Orders
app.MapGet("/restaurants/{restaurantId}/orders", [Authorize(Roles = "user, admin, superadmin")]
async (IOrderRepository repo, Guid restaurantId, IMapper mapper) =>
{
    var orders = await repo.Get(restaurantId);
    var orderContracts = mapper.Map<List<OrderContract>>(orders);
    return Results.Ok(orderContracts);
});

app.MapGet("/restaurants/{restaurantId}/orders/{orderId}", [Authorize(Roles = "user, admin, superadmin")]
async (Guid orderId, Guid restaurantId, IOrderRepository repo, IMapper mapper) =>
{
    var order = await repo.Get(restaurantId, orderId);
    var orderContract = mapper.Map<OrderContract>(order);
    return Results.Ok(orderContract);
});

app.MapPost("/restaurants/{restaurantId}/orders", [Authorize(Roles = "admin, superadmin")] async (CreateOrderContract orderContract, Guid restaurantId, IOrderRepository repo, IMapper mapper) =>
{
    var order = mapper.Map<Order>(orderContract);
    await repo.Create(restaurantId, order);
    var orderContractResult = mapper.Map<OrderContract>(order);
    return Results.Created($"/restaurants/{restaurantId}/orders/{orderContractResult.Id}", orderContractResult);
});

app.MapPut("/restaurants/{restaurantId}/orders", [Authorize(Roles = "admin, superadmin")] async (UpdateOrderContract orderContract, Guid restaurantId, IOrderRepository repo, IMapper mapper) =>
{
    var order = mapper.Map<Order>(orderContract);
    await repo.Update(restaurantId, order);
    return Results.NoContent();
});

app.MapDelete("/restaurants/{restaurantId}/orders/{orderId}", [Authorize(Roles = "admin, superadmin")] async (Guid orderId, Guid restaurantId, IOrderRepository repo) =>
{
    await repo.Delete(restaurantId,orderId);
    return Results.NoContent();
});

// Notes
app.MapGet("/restaurants/{restaurantId}/orders/{orderId}/notes", [Authorize(Roles = "user, admin, superadmin")]
async (INoteRepository repo, Guid restaurantId, Guid orderId, IMapper mapper) =>
{
    var notes = await repo.Get(restaurantId, orderId);
    var noteContracts = mapper.Map<List<NoteContract>>(notes);
    return Results.Ok(noteContracts);
});

app.MapGet("/restaurants/{restaurantId}/orders/{orderId}/notes/{noteId}", [Authorize(Roles = "user, admin, superadmin")] async (Guid noteId, Guid restaurantId, Guid orderId, INoteRepository repo, IMapper mapper) =>
{
    var note = await repo.Get(restaurantId, orderId, noteId);
    var noteContract = mapper.Map<NoteContract>(note);
    return Results.Ok(noteContract);
});

app.MapPost("/restaurants/{restaurantId}/orders/{orderId}/notes", [Authorize(Roles = "admin, superadmin")] async (CreateNoteContract noteContract, Guid restaurantId, Guid orderId, INoteRepository repo, IMapper mapper) =>
{
    var note = mapper.Map<Note>(noteContract);
    await repo.Create(restaurantId, orderId, note);
    var noteContractResult = mapper.Map<NoteContract>(note);
    return Results.Created($"/restaurants/{restaurantId}/orders/{orderId}/notes/{noteContractResult.Id}", noteContractResult);
});

app.MapPut("/restaurants/{restaurantId}/orders/{orderId}/notes", [Authorize(Roles = "admin, superadmin")] async (UpdateNoteContract noteContract, Guid restaurantId, Guid orderId, INoteRepository repo, IMapper mapper) =>
{
    var note = mapper.Map<Note>(noteContract);
    await repo.Update(restaurantId, orderId, note);
    return Results.NoContent();
});

app.MapDelete("/restaurants/{restaurantId}/orders/{orderId}/notes/{noteId}", [Authorize(Roles = "admin, superadmin")] async (Guid noteId, Guid restaurantId, Guid orderId, INoteRepository repo) =>
{
    await repo.Delete(restaurantId, orderId, noteId);
    return Results.NoContent();
});


app.MapPost("/register", [AllowAnonymous] async (CreateUserRequest request, IAuthService authService) =>
{
    var user = await authService.Register(request);
    return Results.Ok(user);
});

app.MapGet("/users", [Authorize(Roles = "admin, superadmin")] async (IRepository<User> repo) =>
{
    var users = await repo.GetAll();
    return Results.Ok(users);
});

app.MapPost("/login", [AllowAnonymous] async (LoginRequest request, IAuthService authService) =>
{
    var jwt = await authService.Login(request);
    return Results.Ok(jwt);
});

app.Run();
