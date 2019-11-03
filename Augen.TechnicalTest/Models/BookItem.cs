using System;

namespace Augen.TechnicalTest.Models
{
    public class BookItem
    {
        public Book VolumeInfo { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string PublishedDate { get; set; }
    }
}
