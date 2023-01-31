namespace Backend.picmapp.Models;

public class DestinationResponse
{
    public string Id { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public DateTime? Date { get; set; }
    public byte[]? Image { get; set; }
}