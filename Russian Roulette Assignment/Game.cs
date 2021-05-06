using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roulette_Assignment
{
    public class Game
    {
        public int Result;
        public int FireCount = 1;
        public int ShootOpponentCount = 1;
        public int ShootOpponentTotal = 2;
        public int Score = 0;
        public int wins = 0;
        public int loses = 0;
        public int ChamberLoad = 0;
        public string path;
        Random rdmChamber = new Random();
        public void spinchamber()
        {
            //Generates the random number (Bullet in chamber)
            Result = rdmChamber.Next(1, 7);
            ShootOpponentCount = 1;
            FireCount = 1;
        }
    }
}
