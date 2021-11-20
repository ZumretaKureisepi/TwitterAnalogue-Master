using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterAnalogue.Model.DTO;
using TwitterAnalogue.WebAPI.Services;

namespace TwitterAnalogue.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PostsController:ControllerBase
    {
        private readonly IPostsService _PostsService;

        public PostsController(IPostsService PostsService)
        {
            _PostsService = PostsService;
        }

        [HttpGet]
        public async Task<List<PostGetDto>> GetBooksAsync()
        {
            return await _PostsService.GetPostsAsync();
        }

        [HttpGet("{id}")]
        public async Task<PostGetDto> GetPostByIdAsync(int id)
        {
            return await _PostsService.GetPostByIdAsync(id);
        }

        [HttpPost]
        public IActionResult SerializeToJSON([FromBody] PostGetDto request)
        {
            return Ok(_PostsService.SerializeToJSON(request));
        }




    }
}
