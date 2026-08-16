using System;
using System.Collections.Generic;
using System.Linq;
using BookLibrary;

namespace BookSearch
{
    public class BookSearcher
    {
        public List<Book> Search(List<Book> books, string searchTerm)
        {
            return books
                .Where(book =>
                    book.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    book.Author.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    book.Genre.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }
    }
}