using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kaliber.Models;

namespace Kaliber.Interfaces
{
    public interface ILoginRepository
    {
        public bool Exists(User user);
    }
}
