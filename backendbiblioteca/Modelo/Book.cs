using System.ComponentModel.DataAnnotations;
namespace backendbiblioteca.Modelo
{
    public class Book
    {
        [Key]
        public int Page { get; set; }
        public string? Title { get; set; }
        public string? Editorial { get; set; }
        public string? Author { get; set; }
        public int BookID { get; set; }
    }
}
