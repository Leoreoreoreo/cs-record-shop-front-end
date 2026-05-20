using System.ComponentModel.DataAnnotations;

public class Album
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Artist { get; set; }
    [Required]
    public string Genre { get; set; }
    [Range(1900, 2100)]
    public int ReleaseYear { get; set; }
    public int Stock { get; set; }
    [Range(0.01, 99999.99)]
    public decimal Price { get; set; }
}
