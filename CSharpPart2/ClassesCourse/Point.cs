using System;

namespace CSharpPart2
{
    public class Point
    {
        //var point = new Point(1, 2);
        //point.ReplaceOriginField(2, 4);
        //Console.WriteLine(point.X);
        //Console.WriteLine(point.Y);
        //try
        //{
        //    point.ReplaceOriginField(null);
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("An unexpected error occured.");
        //}

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void ReplaceOriginField(int x, int y)
        {
            this.X = x; 
            this.Y = y;
        }


        public void ReplaceOriginField(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            // If the method has been throw,
            // the codes after throw will not be execute.
            // This is called defensive programming, that is 
            // to avoid strange operation to affect the program.
            ReplaceOriginField(newLocation.X, newLocation.Y);
        }


    }
}
