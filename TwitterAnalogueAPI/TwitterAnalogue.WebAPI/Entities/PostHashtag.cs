using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterAnalogue.WebAPI.Entities
{
    public class PostHashtag
    {
        public int PostHashtagId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int HashtagId { get; set; }
        public Hashtag Hashtag { get; set; }


    }
}
