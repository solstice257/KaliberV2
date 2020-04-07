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

        List<Book> BorrowedBooks;
        public BookShelf()
        {
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        public void ReadBook(Book book)
        {
            // Path naar book text dunno moet nog uitzoeken
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }

        public int GetAuthorID(Book book, IConfiguration configuration)
        {
            string connectionstring = configuration.GetConnectionString("KaliberConnStr");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT AuthorID FROM Authors WHERE Firstname = @firstname AND Lastname = @lastname";
            cmd.Parameters.AddWithValue("@firstname", book.author.Firstname);
            cmd.Parameters.AddWithValue("@lastname", book.author.Lastname);
            int AuthorID = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            connection.Close();
            return AuthorID;
        }

        public int GetPublisherID(Book book, IConfiguration configuration)
        {
            string connectionstring = configuration.GetConnectionString("KaliberConnStr");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT PublisherID FROM Publisher WHERE Name = @name";
            cmd.Parameters.AddWithValue("@name", book.publisher.Name);
            int PublisherID = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            connection.Close();
            return PublisherID;
        }

        public void AddBook(Book book, IConfiguration configuration)
        {
            string connectionstring = configuration.GetConnectionString("KaliberConnStr");

            SqlConnection connection = new SqlConnection(connectionstring);

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




    }
}
