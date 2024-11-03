using Mihailov_Nicolae_Laborator2.Models;

namespace Mihailov_Nicolae_Laborator2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}
