using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Pustok.Entities
{
    public class Books
    {
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        public Boolean StockStatus { get; set; }
        [MaxLength(100)]
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public Boolean IsNew { get; set; }
        public Boolean IsFeatured { get; set; }


        public decimal Percent { get; set; }

        public List<Authors> Authors { get; set; }
        public List<Genres> Genres { get; set; }
        public List<BooksImage> BooksImages { get; set; }
        public List<BooksOrders> BooksOrders { get; set; }
        public List<BooksTags> BooksTags { get; set; }

    }

}
