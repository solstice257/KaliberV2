using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Kaliber.Repository
{

    public class BookShelf
    {
        string connectionstring;
        SqlConnection connection;

        List<Book> BorrowedBooks;
        public BookShelf(IConfiguration configuration)
        {
            connectionstring = configuration.GetConnectionString("KaliberConnStr");
            connection = new SqlConnection(connectionstring);
            BorrowedBooks = new List<Book>();
        }

        public List<Book> BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
            return BorrowedBooks;
        }

        public void ReadBook(Book book)
        {
            // Path naar book text dunno moet nog uitzoeken
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }

        //public int GetAuthorID(Book book, IConfiguration configuration)
        //{
        //    string connectionstring = configuration.GetConnectionString("KaliberConnStr");

        //    SqlConnection connection = new SqlConnection(connectionstring);

        //    connection.Open();
        //    SqlCommand cmd = connection.CreateCommand();
        //    cmd.CommandText = $"SELECT AuthorID FROM Authors WHERE Firstname = @firstname AND Lastname = @lastname";
        //    cmd.Parameters.AddWithValue("@firstname", book.author.Firstname);
        //    cmd.Parameters.AddWithValue("@lastname", book.author.Lastname);
        //    int AuthorID = (int)cmd.ExecuteScalar();
        //    cmd.Dispose();
        //    connection.Close();
        //    return AuthorID;
        //}

        //public int GetPublisherID(Book book, IConfiguration configuration)
        //{
        //    string connectionstring = configuration.GetConnectionString("KaliberConnStr");

        //    SqlConnection connection = new SqlConnection(connectionstring);

        //    connection.Open();
        //    SqlCommand cmd = connection.CreateCommand();
        //    cmd.CommandText = $"SELECT PublisherID FROM Publisher WHERE Name = @name";
        //    cmd.Parameters.AddWithValue("@name", book.publisher.Name);
        //    int PublisherID = (int)cmd.ExecuteScalar();
        //    cmd.Dispose();
        //    connection.Close();
        //    return PublisherID;
        //}

        public void AddBook(Book book)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Ebooks(AuthorID, PubisherID, Title, Subtitle, Category, CoverPhoto, Year_Of_Publication) VALUES (@AuthorID, @PublisherID, @Title, @Subtitle, @Category, @CoverPhoto, @Year_Of_Publication)";
            cmd.Parameters.AddWithValue("@AuthorID", book.author.AuthorID);
            cmd.Parameters.AddWithValue("@PublisherID", book.publisher.Publisher_ID);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", book.Category);
            cmd.Parameters.AddWithValue("@CoverPhoto", book.Cover_Picture);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", book.Year_Of_Publication);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
        }

        public void DeleteBook(Book book)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Ebooks(AuthorFN, AuthorLN, Title, Subtitle, Category, Year_Of_Publication) VALUES (@AuthorFN, @AuthorLN, @Title, @Subtitle, @Category, @Year_Of_Publication)";
            cmd.Parameters.AddWithValue("@AuthorFN", book.author.Firstname);
            cmd.Parameters.AddWithValue("@AuthorLN", book.author.Lastname);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", book.Category);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", book.Year_Of_Publication);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
        }

        public void UpdateBook(Book book) //WIP NEEDS FIX
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Ebooks(Title, AuthorLN, Title, Subtitle, Category, Year_Of_Publication) VALUES (@AuthorFN, @AuthorLN, @Title, @Subtitle, @Category, @Year_Of_Publication)";
            cmd.Parameters.AddWithValue("@AuthorFN", book.author.Firstname);
            cmd.Parameters.AddWithValue("@AuthorLN", book.author.Lastname);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", book.Category);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", book.Year_Of_Publication);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
        }

        public List<Book> SearchBook(string Element, List<Book> books)
        {
            List<Book> WantedBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Equals(Element))
                {
                    WantedBooks.Add(book);
                }
            }
            return WantedBooks;
        }
    }
}
