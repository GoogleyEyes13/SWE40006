namespace BookLibrary
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(string name, string author, string genre)
        {
            Name = name;
            Author = author;
            Genre = genre;
        }
    }
}