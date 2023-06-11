using System.ComponentModel.DataAnnotations;

namespace Pustok.Entities
{
    public class Genres
    {

        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public int BooksId { get; set; }
        public Books Books { get; set; }
    }
}
