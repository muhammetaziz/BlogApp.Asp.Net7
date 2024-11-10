using BlogApp.Net7.Data.Abstract;
using BlogApp.Net7.Data.Concrete.EfCore;
using BlogApp.Net7.Entity;
using BlogApp.Net7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Net7.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _postRepository;
        private ITagRepository _tagRepository;
        public PostsController(IPostRepository postRepo, ITagRepository tagRepo)
        {
            _postRepository = postRepo;
            _tagRepository = tagRepo;
        }

        public IActionResult Index()
        {
            return View(
                new PostViewModel
                {
                    Posts = _postRepository.Posts.ToList(),
                    Tags = _tagRepository.Tags.ToList(),
                }
                );
        }

        public async Task<IActionResult> PostDetails(int id)
        {

            var post = await _postRepository.Posts.FirstOrDefaultAsync(x => x.PostId == id);
            var post2 = await _postRepository
               .Posts
               .FirstOrDefaultAsync(x => x.PostId == id);
            return View(post2);

        }
        [HttpGet]
        public IActionResult PostAdd() { return View(); }
        [HttpPost]

        public IActionResult PostAdd(Post model)
        {

            model.PublishedOn = DateTime.Now;
            model.UserId = 1;
            _postRepository.PostAdd(model);
            return RedirectToAction("Index");

        }
    }
}
