using System.ComponentModel.DataAnnotations;
using Backend.picmapp.Services;
namespace Backend.picmapp.Models;

public class CardRequest
{
    public string? City { get; set; }
    public string? Country { get; set; }
    public DateTime? Date { get; set; }
    public IFormFile? Image { get; set; }

    public byte[] Convert(IFormFile image)
    {
        var bytes = FileConversion.GetBytes(image);
        //var hexString = Convert.ToBase64String(bytes);

        return bytes;
    }
}