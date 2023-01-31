using System.ComponentModel.DataAnnotations;
using Backend.picmapp.Services;

namespace Backend.picmapp.Models;

public class DestinationRequest
{
    public string? Id { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public double Latitud { get; set; }
    public double Longitud { get; set; }
    public DateTime? Date { get; set; }
    public IFormFile? Image { get; set; }

    public static byte[] GetBytes(IFormFile formFile)
    {
        var memoryStream = new MemoryStream();
        formFile.CopyTo(memoryStream);
        return memoryStream.ToArray();
    }

    public byte[] Converter(IFormFile image)
    {
        var bytes = GetBytes(image);
        return bytes;
    }
}