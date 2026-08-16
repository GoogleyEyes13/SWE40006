using System;
using System.Windows.Forms;
using BookLibrary;

namespace BookManagerApp
{
    public partial class Form1 : Form
    {
        private Library library;
        public Form1()
        {
            InitializeComponent();

            library = new Library();
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
    }
}
