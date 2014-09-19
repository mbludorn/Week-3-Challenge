using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Grid
    {
        //define properites
        public Point[,] Ocean { get; set; }
        public List<Ship> ListOfShips {get; set;}
        public bool AllShipsDestroyed {get}
        public int CombatRount {get; set;}


        //define constructor
        public Grid()
        {
            //initialize the ocean
            this.Ocean = new Point[10, 10];
            this.Ocean[x,y] = new Point(x,y,Point.PointStatus.Empty);
            this.ListOfShips = new List<Ship>();
        


        for (int x = 0; x < 10; x++) //x coordinates
         {
            for (int y = 0; y < 10; y++) //y coordinates
			{
			 this.Ocean[x,y] = new Point(x,y,Point.PointStatus.Empty);
			}
         }

        }
    }
}
