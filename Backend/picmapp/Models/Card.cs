using System.ComponentModel.DataAnnotations;

namespace Backend.picmapp.Models;

public class Card
{
    [Key]
    public int Id { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Date { get; set; }
    public byte[]? Image { get; set; }
}

