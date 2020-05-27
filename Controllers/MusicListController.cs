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
    [Authorize]
    public class MusicListController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ISqlRpgRepository RpgRepository;

        public MusicListController(SignInManager<ApplicationUser> signInManager, ISqlRpgRepository RpgRepository)
        {
            this.RpgRepository = RpgRepository; 
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult AddMusic()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMusic(AddMusicViewModel model)
        {
            if (ModelState.IsValid)
            {
                MusicTrack newAddMusic = new MusicTrack
                {
                    ApplicationUserId = User.Identity.GetUserId(),

                    Name = model.Name,
                    Category = model.Category,
                    Category2 = model.Category2,
                    Category3 = model.Category3,
                    URL = model.URL
                };
                RpgRepository.Add(newAddMusic);
                return RedirectToAction("Details", new { id = newAddMusic.Id });
            }
            return View();
        }
    }
}
