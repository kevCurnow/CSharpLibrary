using _0._18_GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0._18_GuessingGame.Controllers
{
    public class GameController : Controller
    {

        // GET: Game
        public ActionResult Index()
        {
           Session["answer"] = new Random().Next(1, 10);

           return View();
        }

        private bool GuessWasCorrect(int guess) =>
            //cast (int) is the same as convert.to
            guess == (int)Session["answer"];

        //POST: Game
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GameModel model)
        {
            //ModelState is property of GameController
            if (ModelState.IsValid)
            {
                //ViewBag belongs to view, nothing validating if Win is property
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }

            return View(model);
        }
    }
}