using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookLibrary;
using BookSearch;

namespace BookManagerApp
{
    public partial class Form1 : Form
    {
        private Library library;
        private BookSearcher searcher;
        public Form1()
        {
            InitializeComponent();

            library = new Library();
            searcher = new BookSearcher();

            DisplayBooks();
        }

        private void DisplayBooks()
        {
            foreach (Book book in library.Books)
            {
                dataGridView1.Rows.Add(
                    book.Name,
                    book.Author,
                    book.Genre
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();

            dataGridView1.Rows.Clear();

            if (string.IsNullOrEmpty(searchTerm))
            {
                DisplayBooks();
                return;
            }

            List<Book> results = searcher.Search(library.Books, searchTerm);

            foreach (Book book in results)
            {
                dataGridView1.Rows.Add(
                    book.Name,
                    book.Author,
                    book.Genre
                );
            }
        }
    }
}
