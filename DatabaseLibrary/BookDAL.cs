using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Interfaces;
using Interfaces.Interface;
using Interfaces.DTO;



namespace DatabaseLibrary
{
    public class BookDAL : IBookContainersDAL
    {
        SqlConnection connection;
        public BookDAL()
        {
            connection = new SqlConnection("Server=mssql.fhict.local;Database=dbi441576_kaliber;User ID=dbi441576_kaliber;Password=henk123");
        }

        public AuthorDTO GetAuthorByName(string AuthorFN, string AuthorLN)
        {
            string sql =  $"SELECT * FROM Auhtor WHERE Firstname = {AuthorFN} AND Lastname = {AuthorLN}";
            SqlCommand cmd = new SqlCommand(sql, connection);
            AuthorDTO author = (AuthorDTO)cmd.ExecuteScalar();
            return author;
        }

        public void AddBook(BookDTO book)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Ebooks(ISBN, AuthorID, PubisherID, Title, Subtitle, Category, CoverPhoto, Year_Of_Publication) VALUES (@ISBN,  @AuthorID, @PublisherID, @Title, @Subtitle, @Category, @CoverPhoto, @Year_Of_Publication)";
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.Parameters.AddWithValue("@AuthorID", book.author.AuthorID);
            cmd.Parameters.AddWithValue("@PublisherID", book.publisher.PublisherID);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", book.Category);
            cmd.Parameters.AddWithValue("@CoverPhoto", book.Cover_Picture);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", book.Year_of_publication);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
        }

        public void DeleteBook(BookDTO book)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Ebooks(AuthorFN, AuthorLN, Title, Subtitle, Category, Year_Of_Publication) VALUES (@AuthorFN, @AuthorLN, @Title, @Subtitle, @Category, @Year_Of_Publication)";
            cmd.Parameters.AddWithValue("@AuthorFN", book.author.Firstname);
            cmd.Parameters.AddWithValue("@AuthorLN", book.author.Lastname);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", book.Category);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", book.Year_of_publication);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
        }

        public void UpdateBook(BookDTO book) //WIP NEEDS FIX
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Ebooks(Title, AuthorLN, Title, Subtitle, Category, Year_Of_Publication) VALUES (@AuthorFN, @AuthorLN, @Title, @Subtitle, @Category, @Year_Of_Publication)";
            cmd.Parameters.AddWithValue("@AuthorFN", book.author.Firstname);
            cmd.Parameters.AddWithValue("@AuthorLN", book.author.Lastname);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", book.Category);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", book.Year_of_publication);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
        }

        public List<BookDTO> GetAllBooks()
        {
            List<BookDTO> Books = new List<BookDTO>();
            connection.Open();
            DataTable Table = new DataTable();
            string queryString = "SELECT ISBN, Title, Firstname, Preposition, Lastname, Name, Subtitle, Category, CoverPhoto, Year_Of_Publication FROM Ebooks JOIN Author ON Ebooks.AuthorID = Author.AuthorID  JOIN Publisher ON Ebooks.PublisherID = Publisher.PublisherID";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(Table);

            foreach (DataRow row in Table.Rows)
            {
                BookDTO book = new BookDTO();
                book.author = new AuthorDTO();
                book.publisher = new PublisherDTO();
                string strISBN = row["ISBN"].ToString();
                book.Title = row["Title"].ToString();
                book.author.Firstname = row["Firstname"].ToString();
                book.author.Preposition = row["Preposition"].ToString();
                book.author.Lastname = row["Lastname"].ToString();
                book.publisher.PublisherName = row["Name"].ToString();
                book.Subtitle = row["Subtitle"].ToString();
                book.Category = row["Category"].ToString();
                book.Cover_Picture = row["CoverPhoto"].ToString();
                book.Year_of_publication = row["Year_Of_Publication"].ToString();
                long longISBN = Convert.ToInt64(strISBN);
                book.ISBN = longISBN;
                Books.Add(book);
            }
            connection.Close();
            return Books;
        }
    }
}
