using Bogus;
using RestoranuValdymoSistema.Data.Contracts.User;
using RestoranuValdymoSistema.Data.Models;
using RestoranuValdymoSistema.Services;

namespace RestoranuValdymoSistema.Infrastructure
{
    public class DbInitializer
    {
        private readonly IAuthService _authService;
        public List<Restaurant> Restaurants { get; set; }
        public List<CreateUserRequest> UserRequests { get; set; }
        public List<Order> Orders { get; set; }
        public List<Note> Notes { get; set; }

        public DbInitializer()
        {
            Faker<Restaurant> restaurantFaker = new Faker<Restaurant>()
                .StrictMode(false)
                .UseSeed(1)
                .RuleFor(r => r.Id, f => Guid.NewGuid())
                .RuleFor(r => r.CreationDate, f => DateTime.UtcNow)
                .RuleFor(r => r.Name, f => f.Company.CompanyName())
                .RuleFor(r => r.Address, f => f.Address.FullAddress())
                .RuleFor(r => r.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(r => r.Email, f => f.Internet.Email());

            Restaurants = restaurantFaker.Generate(5);

            Faker<Order> orderFaker = new Faker<Order>()
                .StrictMode(false)
                .UseSeed(2)
                .RuleFor(r => r.Id, f => Guid.NewGuid())
                .RuleFor(r => r.CreationDate, f => DateTime.UtcNow)
                .RuleFor(o => o.Item, f => f.Commerce.ProductName())
                .RuleFor(o => o.Description, f => f.Commerce.ProductDescription())
                .RuleFor(o => o.Quantity, f => f.Random.Int(1, 10))
                .RuleFor(o => o.Price, f => f.Random.Decimal(1, 100))
                .RuleFor(o => o.RestaurantId, f => f.PickRandom(Restaurants).Id);

            Orders = orderFaker.Generate(50);

            //Faker<CreateUserRequest> userFaker = new Faker<CreateUserRequest>()
            //    .StrictMode(false)
            //    .UseSeed(3)
            //    .RuleFor(e => e.Name, f => f.Name.FirstName())
            //    .RuleFor(e => e.Surname, f => f.Name.LastName())
            //    .RuleFor(e => e.Role, f => f.PickRandom("admin", "user"))
            //    .RuleFor(e => e.Email, f => f.Internet.Email())
            //    .RuleFor(e => e.PhoneNumber, f => f.Phone.PhoneNumber())
            //    .RuleFor(e => e.RestaurantIds, f => f.PickRandom(Restaurants, 3).Select(r => r.Id).ToList());

            ////Users = userFaker.Generate(30);
            //UserRequests = userFaker.Generate(30);


            Faker<Note> noteFaker = new Faker<Note>()
                .StrictMode(false)
                .UseSeed(4)
                .RuleFor(r => r.Id, f => Guid.NewGuid())
                .RuleFor(r => r.CreationDate, f => DateTime.UtcNow)
                .RuleFor(n => n.Text, f => f.Lorem.Sentence())
                .RuleFor(n => n.OrderId, f => f.PickRandom(Orders).Id);

            Notes = noteFaker.Generate(200);



        }
    }
}
