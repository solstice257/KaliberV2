﻿using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interface
{
    public interface IAuthorContainerDAL
    {
        public void AddAuthor(AuthorDTO author);
    }
}
