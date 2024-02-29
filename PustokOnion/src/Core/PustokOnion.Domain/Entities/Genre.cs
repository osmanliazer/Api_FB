using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustokOnion.Domain.Entities
{
    public class Genre:BaseNameableEntity
    {
        public List<Book> Books { get; set; }
    }
}
