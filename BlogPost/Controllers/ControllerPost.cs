using BlogPost.Model;
using BlogPost.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{

    [ApiController]
    [Route("/api/post")]
    public class ControllerPost:ControllerBase
    {
        private IPostRepository Ipost;

        public ControllerPost(IPostRepository postRepository)
        {
            this.Ipost = postRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Comment>> GetComments() 
        { 
            return await Ipost.GetComments();
        }
    }
}
