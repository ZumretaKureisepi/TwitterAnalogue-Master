using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterAnalogue.Model.DTO
{
    public class PostGetDto
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public bool Verified { get; set; }
        public string PostContent { get; set; }

    }
}
