using System.Collections.Generic;
using System.Threading.Tasks;
using TwitterAnalogue.Model.DTO;

namespace TwitterAnalogue.WebAPI.Services
{
    public interface IPostsService
    {
        public Task<List<PostGetDto>> GetPostsAsync();
        public Task<PostGetDto> GetPostByIdAsync(int id);
        public PostGetDto SerializeToJSON(PostGetDto Post);


    }
}
