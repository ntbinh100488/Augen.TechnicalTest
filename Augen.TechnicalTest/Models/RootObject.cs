using System.Collections.Generic;

namespace Augen.TechnicalTest.Models
{
    public class RootObject
    {
        public int TotalItems { get; set; }
        public List<BookItem> Items { get; set; }
    }
}
