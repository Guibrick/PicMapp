using System.ComponentModel.DataAnnotations;

namespace Backend.picmapp.Models;

public class Destination
{
    [Key]
    public string? Id { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public double Latitud { get; set; }
    public double Longitud { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? Date { get; set; }
    public byte[]? Image { get; set; }
}