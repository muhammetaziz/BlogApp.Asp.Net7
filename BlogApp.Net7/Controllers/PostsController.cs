using BlogApp.Net7.Data.Abstract;
using BlogApp.Net7.Data.Concrete.EfCore;
using BlogApp.Net7.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Net7.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _repository;

        public PostsController(IPostRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var posts = _repository.Posts.ToList();
            return View(posts);
        }

        public async Task<IActionResult> PostDetails(int id)
        {

            var post = await _repository.Posts.FirstOrDefaultAsync(x => x.PostId == id);
            var post2 = await _repository
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
            _repository.PostAdd(model);
            return RedirectToAction("Index");

        }
    }
}
