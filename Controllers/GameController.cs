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
    public class GameController : Controller
    {
        //private readonly Microsoft.AspNet.Identity.UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ISqlRpgRepository RpgRepository;

        public GameController(SignInManager<ApplicationUser> signInManager, ISqlRpgRepository rpgRepository)
        {
            //this.userManager = userManager;
            this.signInManager = signInManager;
            this.RpgRepository = rpgRepository;
        }

        [HttpGet]
        public IActionResult CreateSheet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSheet(CreateSheetViewModel model)
        {
            if (ModelState.IsValid)
            {
                CharacterSheet newCharacterSheet = new CharacterSheet
                {
                    ApplicationUserId = User.Identity.GetUserId(),

                    Name = model.Name,
                    Level = model.Level,
                    Class = model.Class,
                    Personality = model.Personality,
                    Exp = model.Exp,

                    Strength = model.Strength,
                    Agility = model.Agility,
                    Condition = model.Condition,
                    Inteligence = model.Inteligence,
                    Wisdom = model.Wisdom,
                    Charisma = model.Charisma,

                    ArmorClass = model.ArmorClass,
                    Initative = model.Initative,
                    Hp = model.Hp,
                    HpTemp = model.HpTemp,
                    Notes = model.Notes   
                };
                RpgRepository.Add(newCharacterSheet);
                return RedirectToAction("Details", new { id = newCharacterSheet.Id });
            }
            return View();
        }

        [HttpGet]
        public ViewResult SheetsList()
        {
            var model = RpgRepository.GetAllSheets(User.Identity.GetUserId());
            return View(model);
        }

        public IActionResult SheetDelete(int id)
        {
            CharacterSheet characterSheet = RpgRepository.Get(id);
            RpgRepository.Remove(id);
            return RedirectToAction("SheetsList");
        }

        [HttpGet]
        public IActionResult SheetDetails(int? id)
        {
            if(id != null)
            {
                CharacterSheet characterSheet = RpgRepository.Get(id.Value);

                if (characterSheet == null)
                {
                    Response.StatusCode = 404;
                    return View("CharacterSheetNotFound", id.Value);
                }

                SheetDetailsViewModel sheetDetailsViewModel = new SheetDetailsViewModel()
                {
                    characterSheet = characterSheet,
                    pageTitle = "Character Sheet Details"
                };
                return View(sheetDetailsViewModel);
            }
            return RedirectToAction("SheetsDetails");
        }
    }
}