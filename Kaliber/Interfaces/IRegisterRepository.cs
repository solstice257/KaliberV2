using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;

namespace Kaliber.Interfaces
{
    public interface IRegisterRepository
    {
        bool AddedUser(UserView user);
    }
}
