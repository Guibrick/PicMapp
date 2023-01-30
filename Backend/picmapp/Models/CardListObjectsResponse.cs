namespace Backend.picmapp.Models;

public class CardListObjectsResponse
{
    public string id { get; set; }
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;
    public DateTime? Date { get; set; }
    public byte[] Image { get; set; } = null!;

    public CardListObjectsResponse()
    {    
    }
}