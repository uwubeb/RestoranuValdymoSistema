﻿namespace RestoranuValdymoSistema.Data.Contracts.Restaurant;

public class RestaurantContract
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}