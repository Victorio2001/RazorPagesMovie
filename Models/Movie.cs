using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;
/// <summary>
/// Classe Film
/// </summary>
public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; } = DateTime.Today;
    public string? Genre { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0;
    
    public Movie()
    {
    }

    public Movie(int id_film, string title_film, DateTime releasedate_film, string genre_film, decimal price_film)
    {
        id_film = Id;
        title_film = Title;
        releasedate_film = ReleaseDate;
        genre_film = Genre;
        price_film = Price;
    }
}