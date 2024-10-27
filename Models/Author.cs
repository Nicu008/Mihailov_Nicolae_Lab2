using Mihailov_Nicolae_Laborator2.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Mihailov_Nicolae_Laborator2.Models
{
    public class Author
    {
        public int ID { get; set; } // ID-ul autorului
        public string FirstName { get; set; } // Prenumele autorului
        public string LastName { get; set; } // Numele autorului

        [Display(Name = "Full Name")]
        public string FullName => FirstName + " " + LastName;

        // Proprietatea de navigare pentru cărți
        public ICollection<Book>? Books { get; set; }

    }
}
