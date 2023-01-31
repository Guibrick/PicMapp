namespace Backend.picmapp.Models;

public class DestinationListObjectsResponse
{
    public string Id { get; set; }
    public string? City { get; set; } = null!;
    public string? Country { get; set; } = null!;
    public double[] Location { get; set; } = null!;
    public DateTime? Date { get; set; } = null!;

    public DestinationListObjectsResponse()
    {

    }
}