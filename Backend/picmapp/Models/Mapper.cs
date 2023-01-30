using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.picmapp.Services;
namespace Backend.picmapp.Models;

public class Mapper
{
    public Card CardRequestMapping(CardRequest request)
    {
        return new Card
        {
            Id = Guid.NewGuid().ToString(),
            City = request.City,
            Country = request.Country,
            Date = request.Date,
            Image = request.Convert(request.Image),
        };
    }


    public CardResponse makeOne(Card card)
    {
        return new CardResponse
        {
            Id = card.Id,
            City = card.City,
            Country = card.Country,
            Date = card.Date,
            Image = card.Image,
        };
    }
}