using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RPGHelper.Models;
using RPGHelper.ViewModels;

namespace RPGHelper.Controllers
{
    public class MusicListController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IMusicList MusicList;

        public MusicListController(SignInManager<ApplicationUser> signInManager, IMusicList musicList )
        {
            this.MusicList = musicList; 
            this.signInManager = signInManager;
        }
        public IActionResult AddMusic()
        {
            return View();
        }
        public IActionResult AddMusic(AddMusicViewModel model)
        {
            if (ModelState.IsValid)
            {
                MusicList newAddMusic = new MusicList
                {
                    ApplicationUserId = User.Identity.GetUserId(),

                    Name = model.Name,
                    Category = model.Category,
                    URL = model.URL
                };
                MusicList.Add(newAddMusic);
                return RedirectToAction("Details", new { id = newAddMusic.Id });
            }
            return View();
        }
    }
}
