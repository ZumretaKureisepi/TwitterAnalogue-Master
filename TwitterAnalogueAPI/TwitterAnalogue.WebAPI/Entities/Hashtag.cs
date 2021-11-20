using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterAnalogue.WebAPI.Entities
{
    public class Hashtag
    {
        public int HashtagId { get; set; }
        public string Text { get; set; }

        public ICollection<PostHashtag> PostHashtags { get; set; }



    }
}
