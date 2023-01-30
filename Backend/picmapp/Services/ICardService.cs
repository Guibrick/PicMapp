using Backend.picmapp.Models;

namespace Backend.picmapp.Services;

public interface ICardService
{
    Task<List<Card>> GetAll();
    Task<Card>? GetOne(int id);
    Task<Card> Create(Card card);
}