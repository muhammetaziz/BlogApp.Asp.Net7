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
        #region Kurucular

        private IPostRepository _postRepository;
        private ITagRepository _tagRepository;
        public PostsController(IPostRepository postRepo, ITagRepository tagRepo)
        {
            _postRepository = postRepo;
            _tagRepository = tagRepo;
        }
        #endregion
        #region Liste

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
        #endregion
        #region Detaylar

        public async Task<IActionResult> PostDetails(/*string url*/ int? id)
        {

            if (id == null || _postRepository.Posts == null)
            {
                return NotFound();
            }

            var post = await _postRepository.Posts
                 .Include(x => x.Tag)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);


        }
        #endregion
        #region PostEkleme 
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


        #endregion
        #region PostGüncelleme
        public IActionResult PostUpdate(Post model)
        {
            return View();
        }
        #endregion
    }
}
