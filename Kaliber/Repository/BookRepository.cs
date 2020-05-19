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

    public class BookRepository
    {
        string connectionstring;
        SqlConnection connection;

        List<BookView> BorrowedBooks;
        public BookRepository(IConfiguration configuration)
        {
            connectionstring = configuration.GetConnectionString("KaliberConnStr");
            connection = new SqlConnection(connectionstring);
            BorrowedBooks = new List<BookView>();
        }

        public void ReadBook(BookView book)
        {
            // Path naar book text dunno moet nog uitzoeken
        }

        //public int GetAuthorID(BookView book, IConfiguration configuration)
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

        //public int GetPublisherID(BookView book, IConfiguration configuration)
        //{
        //    string connectionstring = configuration.GetConnectionString("KaliberConnStr");

        //    SqlConnection connection = new SqlConnection(connectionstring);

        //    connection.Open();
        //    SqlCommand cmd = connection.CreateCommand();
        //    cmd.CommandText = $"SELECT PublisherID FROM PublisherView WHERE Name = @name";
        //    cmd.Parameters.AddWithValue("@name", book.publisher.Name);
        //    int PublisherID = (int)cmd.ExecuteScalar();
        //    cmd.Dispose();
        //    connection.Close();
        //    return PublisherID;
        //}

        public void AddBook(BookView book)
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

        public void DeleteBook(BookView book)
        {
            connection.Open();

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

        public void UpdateBook(BookView book) //WIP NEEDS FIX
        {
            connection.Open();

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

        public List<BookView> GetAllBooks()
        {
            List<BookView> Books = new List<BookView>();
            connection.Open();
            DataTable Table = new DataTable();
            string queryString = "SELECT ISBN, Title, Firstname, Preposition, Lastname, Name, Subtitle, Category, CoverPhoto, Year_Of_Publication FROM Ebooks JOIN AuthorView ON Ebooks.AuthorID = AuthorView.AuthorID  JOIN PublisherView ON Ebooks.PublisherID = PublisherView.PublisherID";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(Table);
                
            foreach(DataRow row in Table.Rows)
            {
                BookView book = new BookView();
                book.author = new AuthorView();
                book.publisher = new PublisherView();
                string strISBN = row["ISBN"].ToString();
                book.Title = row["Title"].ToString();
                book.author.Firstname = row["Firstname"].ToString();
                book.author.Preposition = row["Preposition"].ToString();
                book.author.Lastname = row["Lastname"].ToString();
                book.publisher.Name = row["Name"].ToString();
                book.Subtitle = row["Subtitle"].ToString();
                book.Category = row["Category"].ToString();
                book.Cover_Picture = row["CoverPhoto"].ToString();
                book.Year_Of_Publication = row["Year_Of_Publication"].ToString();
                long longISBN = Convert.ToInt64(strISBN);
                book.ISBN = longISBN;
                Books.Add(book);
            }
            return Books;
        }
    }
}
