using System.ComponentModel.DataAnnotations;

namespace MOVIES.Models
{
    public class Movie
    {
        public int id { get; set; }
        [Display(Name ="Titulo")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Fecha de liberación")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name ="Genero")]
        public string? Genre { get; set; }
        [Display(Name ="precio")]
        public decimal Price { get; set; }
    }
}
