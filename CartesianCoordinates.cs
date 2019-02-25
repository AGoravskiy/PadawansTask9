using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            if (range < 0 || points.Length == 0)
            {
                throw new ArgumentException();
            }

            if (points == null || point.Equals(null))
            {
                throw new ArgumentNullException();
            }

            List<Point> pointsInRange = new List<Point>();
            foreach (Point item in points)
            {
                if (item.Equals(null))
                {
                    throw new ArgumentNullException();
                }

                if (Math.Abs(item.X - point.X) <= range && 
                    Math.Abs(item.Y - point.Y) <= range)
                {
                    pointsInRange.Add(item);
                }
            }

            return pointsInRange;
        }
    }
}