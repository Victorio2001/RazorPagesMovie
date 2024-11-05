namespace RazorPagesMovie.Models;

public class RatingStatus
{
    public static RatingStatus Mauvais  = new RatingStatus() {Id_Rating = 0, Comment_Rating = "Mauveis"};
    public static RatingStatus Moyen = new RatingStatus() {Id_Rating = 1, Comment_Rating = "Moyen"};
    public static RatingStatus Bon  = new RatingStatus() {Id_Rating = 2, Comment_Rating = "Bon"};
    public static RatingStatus Excellent = new RatingStatus() {Id_Rating = 3, Comment_Rating = "Excellent"};
    
    public int Id_Rating { get; set; } = 0;
    public string Comment_Rating { get; set; } = string.Empty;
}