using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;
/// <summary>
/// Classe Film
/// </summary>
public class Movie
{
    public int Id { get; set; }
    public Acteur Acteur { get; set; } = new Acteur(1, "Ruiz");
    public string? Title { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; } = DateTime.Today;
    public GenreMovie Genre { get; set; } = GenreMovie.comique;
    public RatingStatus Rate { get; set; } = RatingStatus.Moyen;
    public decimal Price { get; set; } = 0;
    
    public Movie()
    {
    }
    
    /// <summary>
    /// Constructeur Classe Movie
    /// </summary>
    /// <param name="id_film"></param>
    /// <param name="title_film"></param>
    /// <param name="releasedate_film"></param>
    /// <param name="genre_film"></param>
    /// <param name="price_film"></param>
    /// <param name="rate_film"></param>
    public Movie(int id_film, string title_film, DateTime releasedate_film, GenreMovie genre_film, decimal price_film, RatingStatus rate_film)
    {
        id_film = Id;
        title_film = Title;
        releasedate_film = ReleaseDate;
        genre_film = Genre;
        rate_film = Rate;
        price_film = Price;
    }
}