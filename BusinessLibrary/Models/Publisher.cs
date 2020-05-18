using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Models
{
    class Publisher
    {
        public int PublisherID { get; private set; }
        public string PublisherName { get; private set; }

        public Publisher(int PublisherID, string PublisherName)
        {
            this.PublisherID = PublisherID;
            this.PublisherName = PublisherName;
        }
    }
}
