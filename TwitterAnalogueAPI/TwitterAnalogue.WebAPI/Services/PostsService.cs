using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TwitterAnalogue.Model.DTO;
using TwitterAnalogue.WebAPI.Entities;

namespace TwitterAnalogue.WebAPI.Services
{
    public class PostsService : IPostsService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public PostsService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PostGetDto>> GetPostsAsync()
        {

            var postsList = await _context.Posts
                .Include(x => x.User)
                .Select(x => new PostGetDto
                {
                    PostId = x.PostId,
                    Name = x.User.Name,
                    Username = x.User.Username,
                    PostContent = x.PostContent,
                    Verified = x.User.Verified
                })
                .ToListAsync();

            return postsList;
        }

        public async Task<PostGetDto> GetPostByIdAsync(int id)
        {
            var postGetDto = await _context.Posts
                .Where(x => x.PostId == id)
                .Include(x => x.User)
                .Select(x => new PostGetDto
                {
                    PostId = x.PostId,
                    Name = x.User.Name,
                    Username = x.User.Username,
                    PostContent = x.PostContent,
                    Verified = x.User.Verified
                })
                .FirstOrDefaultAsync();

            return postGetDto;
        }

        public PostGetDto SerializeToJSON(PostGetDto Post)
        {
            string filePath = "data.save";

            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath))
                File.Delete(filePath);
            StreamWriter sw = new StreamWriter(filePath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonSerializer.Serialize(jsonWriter, Post);

            jsonWriter.Close();
            sw.Close();


            return Post;

        }



    }
}
