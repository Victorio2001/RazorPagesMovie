using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages_Movies;

public class ModelPokemon : PageModel
{
    private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

    public ModelPokemon(RazorPagesMovie.Data.RazorPagesMovieContext context)
    {
        _context = context;
    }
    
    public Movie Film { get; set; }
    
    public void OnGet()
    {
        var Film = new Movie(
            id_film: 1,
            title_film: "Spiderman",
            releasedate_film: System.DateTime.Now, 
            genre_film: GenreMovie.comique,
            price_film: 10
            );
    }
}