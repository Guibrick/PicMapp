using Backend.picmapp.Models;

namespace Backend.picmapp.Services;

public interface IDestinationService
{
    Task<List<Destination>> GetAll();
    Task<Destination>? GetOne(int id);
    Task<Destination> Create(Destination destination);
}