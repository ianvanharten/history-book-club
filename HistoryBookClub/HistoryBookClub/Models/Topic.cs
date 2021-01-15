using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryBookClub.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Title { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        
        public DateTime DateCreated { get; set; }

    }
}
