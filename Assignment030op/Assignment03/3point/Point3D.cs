using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02._3point
{
    //First Project:
    //Define 3D Point Class and the basic Constructors (use chaining in constructors)
    public class Point3D : IComparable<Point3D>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x, int y)
        {
            X = x;
            Y = y;
           
        }
        public Point3D(int x)
        {
            X = x;
          
        }

        public void PointPrint()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
        }
        public void PointPrintUser(int x , int y)
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public override string ToString()
        {
            return $"Point Coordinates: X = {X}, Y = {Y}, Z = {Z}";
        }

        public int CompareTo(Point3D? other)
        {
            int xComparison = X.CompareTo(other.X);
            if (xComparison != 0)
                return xComparison;

            return Y.CompareTo(other.Y);
        }
    }

    
  

    
}
