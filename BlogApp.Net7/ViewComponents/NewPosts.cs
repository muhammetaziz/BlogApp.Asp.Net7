using BlogApp.Net7.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Net7.ViewComponents
{
    public class NewPosts:ViewComponent
    {
        private IPostRepository _postRepository;

        public NewPosts(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        public IViewComponentResult Invoke()
        {
            return View(
                _postRepository
                .Posts
                .OrderByDescending(p=>p.PublishedOn)
                .Take(5)
                .ToList());
        }
    }
}
