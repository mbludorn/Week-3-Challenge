﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Point
    {
        public enum PointStatus
        {
            Empty, Ship, Hit, Miss
        }

        //dfine the properties
        public int X { get; set; }
        public int Y { get; set; }
        public PointStatus Status { get; set; }

        //define constructor
        public Point(int x, int y, PointStatus status)
        {
            this.X = x;
            this.Y = y;
            this.Status = status;
        }

    }
}
