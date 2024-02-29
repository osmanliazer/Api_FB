using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustokOnion.Domain.Entities
{
    public class Book:BaseNameableEntity
    {
        public string Desc { get; set; }
        public int Page { get; set; }
        public bool IsAvailable { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Discount { get; set; }
        public bool IsDeleted { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<BookTag> Booktags { get; set; }
    }
}
