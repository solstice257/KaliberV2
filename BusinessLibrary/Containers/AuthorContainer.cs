using BusinessLibrary.Models;
using Interfaces.DTO;
using Interfaces.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Containers
{
    public class AuthorContainer
    {
        IAuthorContainerDAL iauthorContainerDAL;
        public AuthorContainer(IAuthorContainerDAL iauthorContainerDAL)
        {
            this.iauthorContainerDAL = iauthorContainerDAL;
        }

        public AuthorDTO AuthorToAuthorDTO(Author author)
        {
            AuthorDTO authorDTO = new AuthorDTO(author.AuthorID, author.Firstname, author.Preposition, author.Lastname, author.City, author.Year_of_birth, author.Year_of_death);
            return authorDTO;
        }

        public void AddAuthor(Author author)
        {
            AuthorDTO authorDTO = AuthorToAuthorDTO(author);
            iauthorContainerDAL.AddAuthor(authorDTO);
        }
    }
}
