using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustokOnion.Domain.Entities
{
    public class BookTag: BaseNameableEntity
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
