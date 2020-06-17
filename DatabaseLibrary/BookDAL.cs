using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Interfaces;
using Interfaces.Interface;
using Interfaces.DTO;
using System.Transactions;

namespace DatabaseLibrary
{
    public class BookDAL : IBookContainersDAL, IAuthorContainerDAL
    {
        SqlConnection connection;
        public BookDAL()
        {
            connection = new SqlConnection("Server=mssql.fhict.local;Database=dbi441576_kaliber;User ID=dbi441576_kaliber;Password=henk123");
        }

        public List<AuthorDTO> SearchAuthorByName(string AuthorFN)
        {
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
        }

        public List<BookDTO> SearchBookByTitle(string Title)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT ISBN, Ebooks.AuthorID, Publisher, Title, Subtitle, Category, Year_of_publication, Firstname, Preposition, Lastname, City, Year_of_birth, Year_of_death FROM Ebooks JOIN Author ON Ebooks.AuthorID = Author.AuthorID WHERE Title LIKE @Title";
            cmd.Parameters.AddWithValue("@Title", "%" + Title + "%");
            SqlDataReader rdr = cmd.ExecuteReader();

            List<BookDTO> results = new List<BookDTO>();

            while (rdr.Read())
            {
                AuthorDTO author = new AuthorDTO(Convert.ToInt32(rdr[1]), rdr[7] as string, rdr[8] as string, rdr[9] as string, rdr[10] as string, Convert.ToInt32(rdr[11] as string), Convert.ToInt32(rdr[12] as string));

                BookDTO book = new BookDTO(Convert.ToInt64(rdr[0]), rdr[3] as string, author, rdr[2] as string, rdr[4] as string, rdr[5] as string, null, null, Convert.ToString(rdr[6] as Nullable<int>));
                results.Add(book);
            }
            connection.Close();
            rdr.Close();
            return results;
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

        public void AddAuthor(AuthorDTO author)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Author(Firstname, Preposition, Lastname, City, Year_of_birth, Year_of_death) VALUES (@Firstname, @Preposition, @Lastname, @City, @Year_of_birth, @Year_of_death)";
            cmd.Parameters.AddWithValue("@Firstname", author.Firstname );
            cmd.Parameters.AddWithValue("@Preposition", String.IsNullOrWhiteSpace(author.Preposition) ? (object)DBNull.Value : (object)author.Preposition);
            cmd.Parameters.AddWithValue("@Lastname", String.IsNullOrWhiteSpace(author.Lastname) ? (object)DBNull.Value : (object)author.Lastname); 
            cmd.Parameters.AddWithValue("@City", String.IsNullOrWhiteSpace(author.City) ? (object)DBNull.Value : (object)author.City);
            if(author.Year_of_birth == 0){ cmd.Parameters.AddWithValue("@Year_of_birth", DBNull.Value);}
            else{cmd.Parameters.AddWithValue("@Year_of_birth", author.Year_of_birth);}
            if (author.Year_of_death == 0){cmd.Parameters.AddWithValue("@Year_of_death", DBNull.Value);}
            else{cmd.Parameters.AddWithValue("@Year_of_death", author.Year_of_death);}
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
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
            cmd.CommandText = "DELETE FROM Ebooks WHERE ISBN = @ISBN";
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            connection.Close();
        }

        public void UpdateBook(BookDTO book) //WIP NEEDS FIX
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            SqlTransaction transaction = connection.BeginTransaction(); 
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.CommandText = "UPDATE Ebooks SET Publisher = @Publisher, Title = @Title, Subtitle = @Subtitle, Category = @Category, Year_Of_Publication = @Year_Of_Publication WHERE ISBN = @ISBN";
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd.Parameters.AddWithValue("@Publisher", String.IsNullOrWhiteSpace(book.publisher) ? (object)DBNull.Value : (object)book.publisher);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Subtitle", String.IsNullOrWhiteSpace(book.Subtitle) ? (object)DBNull.Value : (object)book.Subtitle);
            cmd.Parameters.AddWithValue("@Category", String.IsNullOrWhiteSpace(book.Category) ? (object)DBNull.Value : (object)book.Category);
            cmd.Parameters.AddWithValue("@Year_Of_Publication", String.IsNullOrWhiteSpace(book.Year_of_publication) ? (object)DBNull.Value : (object)book.Year_of_publication);

            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.Connection = connection;
            cmd2.Transaction = transaction;
            cmd2.CommandText = "UPDATE Ebooks SET AuthorID = @AuthorID WHERE ISBN = @ISBN";
            cmd2.Parameters.AddWithValue("@ISBN", book.ISBN);
            cmd2.Parameters.AddWithValue("@AuthorID", book.author.AuthorID);

            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SqlException)
            {
                transaction.Rollback();
                throw;
            }
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
