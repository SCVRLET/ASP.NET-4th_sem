using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStore.Models;
using Microsoft.AspNetCore.Authorization;
using BuisnessLayer;
using BisonessLayer.DTO;

namespace UserStore.Controllers
{

    public class UsersController : Controller
    {
        UserManager<User> _userManager;
        private readonly DataManager _dataManager;

        public UsersController(UserManager<User> userManager, DataManager dataManager)
        {
            _userManager = userManager;
            _dataManager = dataManager;
        }

        public async Task<IActionResult> Settings(string postText)
        {
            return View(_userManager.FindByNameAsync(HttpContext.User.Identity.Name).Result);
        }

        public async Task<IActionResult> MyProfile(string postText)
        {
            return RedirectToAction("Profile", "Home", new { userName = HttpContext.User.Identity.Name });
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(string postText)
        {
            var cur_user = _userManager.FindByNameAsync(HttpContext.User.Identity.Name).Result;

            _dataManager.Posts.AddPost(cur_user.Id, postText);

             return RedirectToAction("Profile", "Home", new { userName = HttpContext.User.Identity.Name });
        }

        [HttpPost]
        public JsonResult DeletePost(int postId)
        {
            var curr_user_id = _userManager.FindByNameAsync(HttpContext.User.Identity.Name).Result.Id;

            if (_dataManager.Posts.FindPost(postId).UserId == curr_user_id)
                _dataManager.Posts.DeletePost(postId);

            var profile_posts = _dataManager.Posts.GetProfilePosts(curr_user_id);
            profile_posts.Reverse();

            return Json(new { });
        }
        
        [HttpPost]
        public async Task<JsonResult> LikeOrDeleteLike(int postId)
        {
            var curr_user = _userManager.FindByNameAsync(HttpContext.User.Identity.Name).Result;

            if(_dataManager.Posts.FindLike(postId, curr_user.Id) == null)
            {
                _dataManager.Posts.AddLike(postId, curr_user.Id);
                return Json(new { like = true, likes_number = _dataManager.Posts.FindPost(postId).Likes.Count(), postId = postId });
            }

            else
            {
                _dataManager.Posts.RemoveLike(postId, curr_user.Id);
                return Json(new { like = false, likes_number = _dataManager.Posts.FindPost(postId).Likes.Count(), postId = postId });
            }
        }

        public async Task<IActionResult> Edit(string id)
        {
            User user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            EditUserViewModel model = new EditUserViewModel { Id = user.Id, Email = user.Email, FirstName = user.FirstName };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                    user.FirstName = model.FirstName;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            User user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            ChangePasswordViewModel model = new ChangePasswordViewModel { Id = user.Id, Email = user.Email };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    IdentityResult result =
                        await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Пользователь не найден");
                }
            }
            return View(model);
        }
    }
}
