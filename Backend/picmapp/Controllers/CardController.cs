using Backend.picmapp.Models;
using Backend.picmapp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Backend.picmapp.Controller;

[ApiController]
[Route("api/[controller]")]
public class CardController : ControllerBase
{
    private readonly PicMappContext _context;
    private readonly Mapper mapper = new();

    public CardController(PicMappContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Card>>> GetAllCards()
    {
        if (_context.Cards == null) return NotFound();
        return await _context.Cards.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Card>> GetOneCard(int id)
    {
        if (_context.Cards == null) return NotFound();

        var card = await _context.Cards.FindAsync(id);
        if (card == null) return NotFound();

        return card;
    }

    [HttpPost]
    public async Task<ActionResult<Card>> PostCard([FromForm] CardRequest card)
    {
        if (_context.Cards == null) return Problem("Entity set is null.");

        var addition = mapper.CardRequestMapping(card);
        await _context.AddAsync(addition);

        return CreatedAtAction("GetOneCard", new { id = Guid.NewGuid() }, mapper.makeOne(addition));
    }

    /*public void Remove(int id)
    {
        products.RemoveAll(p => p.Id == id);
    }

    public bool Update(Product item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("item");
        }
        int index = products.FindIndex(p => p.Id == item.Id);
        if (index == -1)
        {
            return false;
        }
        products.RemoveAt(index);
        products.Add(item);
        return true;
    }*/
}