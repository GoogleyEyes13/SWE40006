using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RandomBookGenerator.Models;

namespace RandomBookGenerator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public Book? RandomBook { get; set; }

        private readonly List<Book> Books = new()
        {
            new Book
            {
                Title = "Pie Rats: The Forgotten Map",
                Author = "Cameron Stelzer",
                Genre = "Fantasy, Action, Adventure"
            },
            new Book
            {
                Title = "Contagion",
                Author = "Teri Terry",
                Genre = "Science Fiction, Thriller, Dystopian"
            },
            new Book
            {
                Title = "Fire and Thorns",
                Author = "Rae Carson",
                Genre = "Fantasy, Fiction, Romance"
            },
            new Book
            {
                Title = "Skulduggery Pleasant",
                Author = "Derek Landy",
                Genre = "Dark Fantasy, Mystery, Comedy"
            },
            new Book
            {
                Title = "The Turners",
                Author = "Mick Elliott",
                Genre = "Humour, Fantasy Fiction, Adventure"
            },
            new Book
            {
                Title = "The Hunger Games",
                Author = "Suzanne Collins",
                Genre = "Dystopian Fiction, Action"
            },
            new Book
            {
                Title = "Project Hail Mary",
                Author = "Andy Weir",
                Genre = "Hard Science Fiction, Thriller, Space"
            },
            new Book
            {
                Title = "Self/less",
                Author = "Aviva",
                Genre = "Dystopian Fiction, Science Fiction"
            },
            new Book
            {
                Title = "Lightlark",
                Author = "Alex Aster",
                Genre = "Fantasy, Romance, Thriller"
            },
            new Book
            {
                Title = "Six of Crows",
                Author = "Leigh Bardugo",
                Genre = "Fantasy, Crime Fiction, Adventure"
            },
            new Book
            {
                Title = "Love, Lies and Spies",
                Author = "Cindy Anstey",
                Genre = "Historical Fiction, Romance, Spy"
            },
            new Book
            {
                Title = "Percy Jackson and the Lightning Thief",
                Author = "Rick Riordan",
                Genre = "Fantasy, Adventure, Greek Mythology"
            },
            new Book
            {
                Title = "Only the Animals",
                Author = "Ceridwen Dovey",
                Genre = "Short Story Collection, Magical Realism, Fiction"
            },
            new Book
            {
                Title = "The Lady's Guide to Petticoats and Piracy",
                Author = "Mackenzi Lee",
                Genre = "Historial Fiction, Adventure, Fiction"
            },
            new Book
            {
                Title = "The Happiest Man on Earth",
                Author = "Eddie Jaku",
                Genre = "Non-fiction, Memoir, Biography"
            }
        };
        
        public void OnGet()
        {

        }

        public void OnPost()
        {
            Random random = new Random();

            int index = random.Next(Books.Count);

            RandomBook = Books[index];
        }
    }
}
