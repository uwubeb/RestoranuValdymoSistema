using AutoMapper;
using RestoranuValdymoSistema.Data.Contracts.Note;
using RestoranuValdymoSistema.Data.Contracts.Order;
using RestoranuValdymoSistema.Data.Contracts.Restaurant;
using RestoranuValdymoSistema.Data.Models;

namespace RestoranuValdymoSistema;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Restaurant, RestaurantContract>()
            .ReverseMap();

        CreateMap<Order, OrderContract>()
            .ReverseMap();

        CreateMap<Note, NoteContract>()
            .ReverseMap();
    }
}