using Microsoft.AspNetCore.Mvc;
using TweetBook.Domain;

namespace TweetBook.Controllers;

public class PostsController : Controller
{
    private List<Post> _posts;

    public PostsController()
    {
        _posts = new List<Post>();
        for (int i = 0; i < 5; i++)
        {
            _posts.Add(new Post{ Id = Guid.NewGuid().ToString() });
        }
    }

    [HttpGet("api/v1/posts")]
    public IActionResult GetAll() => Ok(_posts);
}