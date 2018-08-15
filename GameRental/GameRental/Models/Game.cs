using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRental.Models
{
    public class Game
    {
        public int GameId { get; set; }
       
        public string GameName{ get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public Standard standard { get; set; }
    }
}public class Standard
{
    public int StandardId { get; set; }
    public string StandardName { get; set; }

}



