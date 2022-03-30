using System.ComponentModel.DataAnnotations;

namespace example.Web.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        [Phone]
        public string Tel { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
