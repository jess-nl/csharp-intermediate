﻿using System;
namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
            //this.X = newLocation.X; // no need for this 'cause of Move(newLocation.X, newLocation.Y);
            //this.Y = newLocation.Y; // no need for this 'cause of Move(newLocation.X, newLocation.Y);
        }
    }
}