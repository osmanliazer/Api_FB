﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustokOnion.Domain.Entities
{
    public class Tag: BaseNameableEntity
    {
        public List<BookTag>? Booktags { get; set; }
    }
}
