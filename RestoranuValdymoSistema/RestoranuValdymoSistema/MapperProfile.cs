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

        CreateMap<CreateRestaurantContract, Restaurant>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Orders, opt => opt.Ignore())
            .ForMember(dest => dest.Employees, opt => opt.Ignore());
        
        CreateMap<UpdateRestaurantContract, Restaurant>()
            .ForMember(dest => dest.Orders, opt => opt.Ignore())
            .ForMember(dest => dest.Employees, opt => opt.Ignore());


        CreateMap<Order, OrderContract>()
            .ReverseMap();
        CreateMap<CreateOrderContract, Order>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Notes, opt => opt.Ignore())
            .ForMember(dest => dest.Restaurant, opt => opt.Ignore())
            .ForMember(dest => dest.RestaurantId, opt => opt.Ignore());

        CreateMap<UpdateOrderContract, Order>()
            .ForMember(dest => dest.Notes, opt => opt.Ignore())
            .ForMember(dest => dest.Restaurant, opt => opt.Ignore())
            .ForMember(dest => dest.RestaurantId, opt => opt.Ignore());
        
        CreateMap<Note, NoteContract>()
            .ReverseMap();
        CreateMap<CreateNoteContract, Note>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Order, opt => opt.Ignore())
            .ForMember(dest => dest.OrderId, opt => opt.Ignore());
        CreateMap<UpdateNoteContract, Note>()
            .ForMember(dest => dest.Order, opt => opt.Ignore())
            .ForMember(dest => dest.OrderId, opt => opt.Ignore());

    }
}