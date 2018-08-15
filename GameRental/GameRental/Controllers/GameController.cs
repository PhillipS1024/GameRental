using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameRental.Controllers
{
    public class GameController : Controller
    {
        IList<Game> List = new List<Game>() {
                    new Game() { GameId = 1, GameName = "Destiny 2", Year = 2012, Price = 50 } ,
               new Game() { GameId = 2,GameName = "God of War", Year = 2001,  Price = 20 } ,
               new Game() { GameId = 3,GameName = "Grand Theft Auto", Year = 2014,  Price = 25 } ,
               new Game() { GameId = 4,GameName = "Divison", Year = 2015 , Price = 25 } ,
               new Game() { GameId = 5,GameName = "Road Blocks", Year = 2005 , Price = 5 } ,
               new Game() { GameId = 4,GameName = "OverWatch", Year = 2013 , Price = 30 } ,
               new Game() { GameId = 5,GameName = "NBA Live", Year = 2018 , Price = 50 }
                };
        
        public ActionResult Index()
        {
            return View(List);
        }

        public ActionResult Edit(int Id)
        {
            
            var std = List.Where(s => s.GameId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Game std)
        {
             

            return RedirectToAction("Index");
        }

    }








}
