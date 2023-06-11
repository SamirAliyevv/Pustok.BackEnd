using System.ComponentModel.DataAnnotations;

namespace Pustok.Entities
{
    public class Authors
    {

        public int Id { get; set; }

        [MaxLength(70)]
        public string FullName { get; set; }
        public int BooksId { get; set; }
        public Books Books { get; set; }
        
    }
}
