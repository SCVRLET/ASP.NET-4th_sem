using BisonessLayer.DTO;
using BuisnessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserStore.Models;
using User = UserStore.Models.User;

namespace UserStore.Controllers
{
    /*[Route("[controller]")]*/
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly DataManager _dataManager;

        public HomeController(UserManager<User> userManager, DataManager dataManager)
        {
            _userManager = userManager;
            _dataManager = dataManager;
        }

        public IEnumerable<PostDTO> GetDTOPosts(string id)
        {
            var ret = new List<PostDTO>();
            var rawPosts = _dataManager.Posts.GetProfilePosts(id);

            if (rawPosts != null)
            {
                foreach (var post in rawPosts)
                {

                    ret.Add(new PostDTO { CreatedAt = post.CreatedAt, Id = post.Id, UserId = post.UserId, Text = post.Text });

                    if (post.Likes.Count() > 0)
                        foreach (var like in post.Likes)
                        {
                            ret.LastOrDefault().Likes.Add(new LikeDTO { Id = like.Id, PostId = post.Id, UserId = post.UserId });
                        }

                    if (post.Comments.Count() > 0)
                        foreach (var comment in post.Comments)
                        {
                            ret.LastOrDefault().Comments.Add(new CommentDTO
                            {
                                Id = comment.Id,
                                PostId = comment.Id,
                                UserId = comment.UserId,
                                CreatedAt = comment.CreatedAt,
                                Text = comment.Text
                            });
                        }

                    if (post.PostImages.Count() > 0)
                        foreach (var img in post.PostImages)
                        {
                            ret.LastOrDefault().PostImages.Add(new PostImageDTO { Id = img.Id, Image = img.Image, PostId = img.PostId });
                        }
                }
            }

            return ret;
        }
        public async Task<IActionResult> Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Profile", new { userName = HttpContext.User.Identity.Name });
            }

            return RedirectToAction("Login", "Account");
        }

        /*[HttpGet("[action]/[userName]")]*/
        public async Task<IActionResult> Profile(string userName)
        {
            User user = _userManager.FindByNameAsync(userName).Result;


            IEnumerable<PostDTO> userPosts = GetDTOPosts(user.Id);

            ProfileViewModel profile = new ProfileViewModel { User = user, UserPosts = userPosts };

            return View(profile);
        }
         
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
