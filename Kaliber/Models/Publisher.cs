using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaliber
{
    public class Publisher
    {
        public int Publisher_ID;
        public string Name;

        public Publisher(int Publisher_ID, string Name)
        {
            this.Publisher_ID = Publisher_ID;
            this.Name = Name;
        }
    }
}
