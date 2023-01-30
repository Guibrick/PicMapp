using System.ComponentModel.DataAnnotations;

namespace Backend.picmapp.Models;

public class CardResponse
{
    public string Id { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public DateTime? Date { get; set; }
    public byte[]? Image { get; set; }
}