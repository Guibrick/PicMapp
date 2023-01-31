using Backend.picmapp.Models;
using Backend.picmapp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.picmapp.Controller;

[ApiController]
[Route("api/[controller]")]
public class DestinationController : ControllerBase
{
    private readonly MappContext _context;

    public DestinationController(MappContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Destination>> GetAllDestinations()
    {
        if (_context.Destinations == null) return NotFound();
        return _context.Destinations.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Destination> GetOneDestination(string id)
    {
        if (_context.Destinations == null) return NotFound();

        var destination = _context.Destinations.Find(id);
        if (destination == null) return NotFound();

        return destination;
    }

    [HttpPost]
    public ActionResult<Destination> PostDestination([FromForm] DestinationRequest destination)
    {
        if (_context.Destinations == null) return Problem("Entity set is null.");

        _context.Add(new Destination()
        {
            Id = Guid.NewGuid().ToString(),
            City = destination.City,
            Country = destination.Country,
            Latitud = destination.Latitud,
            Longitud = destination.Longitud,
            Date = destination.Date,
            Image = destination.Converter(destination.Image),
        });
        _context.SaveChanges();

        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult<Destination> UpdateDestination(string id, [FromForm] DestinationRequest destination)
    {
        if (id != destination.Id) return BadRequest();

        var existingDestination = _context.Destinations
                                    .Where(d => d.Id == destination.Id)
                                    .FirstOrDefault<Destination>();

        if (existingDestination != null)
        {
            existingDestination.City = destination.City;
            existingDestination.Country = destination.Country;
            existingDestination.Latitud = destination.Latitud;
            existingDestination.Longitud = destination.Longitud;
            existingDestination.Date = destination.Date;
            existingDestination.Image = destination.Converter(destination.Image);

            _context.SaveChanges();
        }
        else
        {
            return NotFound();
        }
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteDestination(string id)
    {
        if (_context.Destinations == null) return NotFound();
        var destination = _context.Destinations.Find(id);
        if (destination == null) return NotFound();

        _context.Destinations.Remove(destination);
        _context.SaveChanges();

        return NoContent();
    }

    private bool DestinationExists(string id)
    {
        return (_context.Destinations?.Any(d => d.Id == id)).GetValueOrDefault();
    }
}