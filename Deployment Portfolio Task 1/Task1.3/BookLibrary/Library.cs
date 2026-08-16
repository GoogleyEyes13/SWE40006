using System.Collections.Generic;

namespace BookLibrary
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public Library()
        {
            Books.Add(new Book("Skulduggery Pleasant", "Derek Landy", "Dark Fantasy"));
            Books.Add(new Book("Twelve Angry Men", "Reginald Rose", "Crime Fiction"));
            Books.Add(new Book("Throne of Glass", "Sarah J. Maas", "Fantasy"));
            Books.Add(new Book("The Boy in Striped Pyjamas", "John Boyne", "Historical Fiction"));
        }
    }
}
