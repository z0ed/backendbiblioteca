using System.ComponentModel.DataAnnotations;
namespace backendbiblioteca.Modelo
{
    public class Student
    {
        [Key]
        public int? Loans { get; set; }
        public string? Name { get; set; }
        public string? Carreer{ get; set; }
        public string? Semester {get; set; }
        public int? StudentID { get; set; }

    }
}
