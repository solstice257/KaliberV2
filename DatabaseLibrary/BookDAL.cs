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

        public List<AuthorDTO> SearchAuthorByName(string AuthorFN)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Author WHERE Firstname LIKE @Firstname";
                cmd.Parameters.AddWithValue("@Firstname", "%" + AuthorFN + "%");
                SqlDataReader rdr = cmd.ExecuteReader();

                List<AuthorDTO> results = new List<AuthorDTO>();

                while (rdr.Read())
                {
                    AuthorDTO author = new AuthorDTO(Convert.ToInt32(rdr[0]), rdr[1] as string, rdr[2] as string, rdr[3] as string, rdr[4] as string, Convert.ToInt32(rdr[5] as string), Convert.ToInt32(rdr[6] as string));
                    results.Add(author);
                }
                connection.Close();
                rdr.Close();
                return results;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }

        public AuthorDTO GetAuthorByName(string AuthorFN, string AuthorLN)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Author WHERE Firstname LIKE @Firstname AND Lastname LIKE @Lastname";
            cmd.Parameters.AddWithValue("@Firstname", AuthorFN);
            cmd.Parameters.AddWithValue("@Lastname", AuthorLN);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                AuthorDTO author = new AuthorDTO(Convert.ToInt32(rdr[0]), rdr[1] as string, rdr[2] as string, rdr[3] as string, rdr[4] as string, Convert.ToInt32(rdr[5] as string), Convert.ToInt32(rdr[6] as string));
                rdr.Close();
                connection.Close();
                return author;
            }
            rdr.Close();
            connection.Close();
            return null;
        }

        public void AddBook(BookDTO book, int AuthorID)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Ebooks(ISBN, AuthorID, Publisher, Title, Subtitle, Category, CoverPhoto, Year_Of_Publication) VALUES (@ISBN, @AuthorID, @Publisher, @Title, @Subtitle, @Category, @CoverPhoto, @Year_Of_Publication)";
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
            cmd.Parameters.AddWithValue("@Publisher", String.IsNullOrWhiteSpace(book.publisher) ? (object)DBNull.Value : (object)book.publisher);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", String.IsNullOrWhiteSpace(book.Subtitle) ? (object)DBNull.Value : (object)book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", String.IsNullOrWhiteSpace(book.Category) ? (object)DBNull.Value : (object)book.Category); 
            cmd.Parameters.AddWithValue("@CoverPhoto", String.IsNullOrWhiteSpace(book.Cover_Picture) ? (object)DBNull.Value : (object)book.Cover_Picture);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", String.IsNullOrWhiteSpace(book.Year_of_publication) ? (object)DBNull.Value : (object)book.Year_of_publication);
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
            try
            {
                connection.Close();
                List<BookDTO> Books = new List<BookDTO>();
                //connection.Open();
                DataTable Table = new DataTable();
                string queryString = "SELECT ISBN, Title, Publisher, Firstname, Preposition, Lastname, Subtitle, Category, CoverPhoto, Year_Of_Publication FROM Ebooks JOIN Author ON Ebooks.AuthorID = Author.AuthorID";
                SqlCommand cmd = new SqlCommand(queryString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Table);

                foreach (DataRow row in Table.Rows)
                {
                    BookDTO book = new BookDTO();
                    book.author = new AuthorDTO();
                    string strISBN = row["ISBN"].ToString();
                    book.Title = row["Title"].ToString();
                    book.author.Firstname = row["Firstname"].ToString();
                    book.author.Preposition = row["Preposition"].ToString();
                    book.author.Lastname = row["Lastname"].ToString();
                    book.publisher = row["Publisher"].ToString();
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
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
