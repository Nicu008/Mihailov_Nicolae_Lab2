using System.ComponentModel.DataAnnotations;

namespace Mihailov_Nicolae_Laborator2.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        [Display(Name = "Member Name")]
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        [Display(Name = "Book Title")]
        public int? BookID { get; set; }
        public Book? Book { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
