using Google.Apis.Books.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class BookshelvesDto
    {
        public string Kind { get; set; }
        public List<Bookshelf> Items { get; set; }
    }
}
