using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.DTO;

namespace BusinessLibrary.Models
{
    public class Publisher
    {
        public int PublisherID { get; private set; }
        public string PublisherName { get; private set; }

        public Publisher(PublisherDTO publisherDTO)
        {
            this.PublisherID = publisherDTO.PublisherID;
            this.PublisherName = publisherDTO.PublisherName;
        }
    }
}
