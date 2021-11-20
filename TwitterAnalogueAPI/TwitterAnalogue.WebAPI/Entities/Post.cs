using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterAnalogue.WebAPI.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostContent { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<PostHashtag> PostHashtags { get; set; }


    }
}
