using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1 Q4
            //Point_3D P1 = new Point_3D(10, 10, 10);
            //Point_3D P2 = new Point_3D(13, 14, 11);

            //if (P1 == P2)
            //{
            //    Console.WriteLine("Worked");
            //}

            //Runtime Error
            #endregion

            #region Part1 Q5 Define an array of points and sort this array based on X & Y coordinates
            //Point_3D P1 = new Point_3D(10, 10, 10);
            //Point_3D P2 = new Point_3D(17, 14, 11);
            //Point_3D P3 = new Point_3D(15, 16, 11);

            //Point_3D[] ArrOfPoints= { P1, P2, P3 };

            //Point_3D.SortArr(ArrOfPoints);

            //for (int i = 0; i < ArrOfPoints.Length; i++)
            //{
            //    Console.WriteLine(ArrOfPoints[i]);
            //}
            #endregion

            #region Part_2 Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
            //float X = 10; float Y = 20;
            //Console.WriteLine(Maths.Add(Y, X));
            //Console.WriteLine(Maths.Multiply(Y, X));
            //Console.WriteLine(Maths.Subtract(Y, X));
            //Console.WriteLine(Maths.Divide(Y, X));
            #endregion


        }
    }


    #region Part_1 "First Project

    #region Q1 Define 3D Point Class and the basic Constructors (use chaining in constructors).
    public class Point_3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point_3D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point_3D(int x, int y, int z) : this(x, y)
        {
            Z = z;
        }

        #region Q2 Override the ToString Function to produce this output:

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        #endregion

        #region Q3 Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
        public bool Read2Points()
        {
            int Num1 = 0, Num2 = 0;
            Console.WriteLine("Enter X value");
            if (int.TryParse(Console.ReadLine(), out Num1))
            {
                this.X = Num1;
            }
            else
            {
                return false;
            }

            if (int.TryParse(Console.ReadLine(), out Num2))
            {
                this.Y = Num2;
            }
            else
            {
                return false;
            }

            return true;
        }
        #endregion

        public static bool operator >(Point_3D a, Point_3D b)
        {
            if (a.X > b.X)
            {
                return true;
            }
            else if (a.X < b.X)
            {
                return false;
            }
            else if (a.Y > b.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Point_3D a, Point_3D b)
        {
            if (a.X < b.X)
            {
                return true;
            }
            else if (a.X > b.X)
            {
                return false;
            }
            else if (a.Y < b.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Q5 Define an array of points and sort this array based on X & Y coordinates. 

        static public void SortArr(Point_3D[] arr)
        {
            Point_3D temp = new Point_3D(0, 0, 0);
            if (arr is not null)
            {
                Point_3D[] Arr = new Point_3D[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
        }

        #endregion

    }
    #endregion

    #endregion

    #region Part_2 Second Project

    public class Maths
    {
        public static Double Add(Double Num1, Double Num2)
        {
            return Num1 + Num2;
        }

        public static Double Subtract(Double Num1, Double Num2)
        {
            return Num1 - Num2;
        }

        public static Double Multiply(Double Num1, Double Num2)
        {
            return Num1 * Num2;
        }

        public static Double Divide(Double Num1, Double Num2)
        {
            return Num1 / Num2;
        }
    }

    #endregion

 

}
