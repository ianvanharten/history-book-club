using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryBookClub.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Message { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
