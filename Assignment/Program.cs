﻿using System;
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


    #region Part3

    public class Duration
    {
        #region Q1 Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Q2 Override All System.Object Members (ToString, Equals,GetHasCode) .

        public override string ToString()
        {
            return $"Hours: {Hours} Mins: {Minutes} Secs: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
            {
                if (this.Hours != other.Hours)
                    return false;
                else if (this.Minutes != other.Minutes)
                    return false;
                else if (this.Seconds != other.Seconds)
                    return false;
                else return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        #endregion

        #region Q3 Define All Required Constructors to Produce this output:

        public Duration(int H, int M, int S)
        {
            Hours = H;
            Minutes = M;
            Seconds = S;
        }

        public Duration(int Num)
        {
            Hours = Num / 3600;
            Minutes = (Num - 3600 * Hours) / 60;
            Seconds = (Num - (3600 * Hours + 60 * Minutes));
        }

        #endregion

        #region Q4 Implement All required Operators overloading to enable this Code

        static public Duration operator +(Duration Left, int Right)
        {
            Duration duration = new Duration(0, 0, 0);
            Duration RightTime = new Duration(Right);
            if ((Left is not null) & (RightTime is not null))
            {
                duration.Hours = Left.Hours + RightTime.Hours;
                if ((Left.Minutes + RightTime.Minutes) > 60)
                {
                    duration.Hours += 1;
                    duration.Minutes = (Left.Minutes + RightTime.Minutes) - 60;
                }
                else
                {
                    duration.Minutes = Left.Minutes + RightTime.Minutes;
                }

                if ((Left.Seconds + RightTime.Seconds) > 60)
                {
                    duration.Minutes += 1;
                    duration.Seconds = (Left.Seconds + RightTime.Seconds) - 60;
                }
                else
                {
                    duration.Minutes = Left.Seconds + RightTime.Seconds;
                }

                return duration;
            }
            return duration;
        }

        static public Duration operator +(Duration Left, Duration Right)
        {
            Duration duration = new Duration(0, 0, 0);
            if ((Left is not null) & (Right is not null))
            {
                duration.Hours = Left.Hours + Right.Hours;
                if ((Left.Minutes + Right.Minutes) > 60)
                {
                    duration.Hours += 1;
                    duration.Minutes = (Left.Minutes + Right.Minutes) - 60;
                }
                else
                {
                    duration.Minutes = Left.Minutes + Right.Minutes;
                }

                if ((Left.Seconds + Right.Seconds) > 60)
                {
                    duration.Minutes += 1;
                    duration.Seconds = (Left.Seconds + Right.Seconds) - 60;
                }
                else
                {
                    duration.Minutes = Left.Seconds + Right.Seconds;
                }

                return duration;
            }
            return duration;
        }

        static public Duration operator +(int Left, Duration Right)
        {
            Duration duration = new Duration(0, 0, 0);
            Duration LeftTime = new Duration(Left);
            if ((LeftTime is not null) & (Right is not null))
            {
                duration.Hours = LeftTime.Hours + Right.Hours;
                if ((LeftTime.Minutes + Right.Minutes) > 60)
                {
                    duration.Hours += 1;
                    duration.Minutes = (LeftTime.Minutes + Right.Minutes) - 60;
                }
                else
                {
                    duration.Minutes = LeftTime.Minutes + Right.Minutes;
                }

                if ((LeftTime.Seconds + Right.Seconds) > 60)
                {
                    duration.Minutes += 1;
                    duration.Seconds = (LeftTime.Seconds + Right.Seconds) - 60;
                }
                else
                {
                    duration.Minutes = LeftTime.Seconds + Right.Seconds;
                }

                return duration;
            }
            return duration;
        }

        static public Duration operator ++(Duration D)
        {
            D.Minutes += 1;
            return D;
        }

        static public Duration operator --(Duration D)
        {
            D.Minutes -= 1;
            return D;
        }

        static public Duration operator -(Duration Left, Duration Right)
        {
            int Num1 = 0, Num2 = 0;
            Duration duration = new Duration(0, 0, 0);
            if ((Left is not null) & (Right is not null))
            {
                Num1 = (Left.Hours) * 3600 + (Left.Minutes * 60) + Left.Seconds;
                Num2 = (Right.Hours) * 3600 + (Right.Minutes * 60) + Right.Seconds;

                if (Num2 > Num1)
                {
                    return new Duration(0, 0, 0); ;
                }
                else
                {
                    duration = new Duration((Num1 - Num2));
                }
                return duration;
            }
            return duration;
        }

        static public bool operator >(Duration Left, Duration Right)
        {
            int Num1 = 0, Num2 = 0;
            if ((Left is not null) & (Right is not null))
            {
                Num1 = (Left.Hours) * 3600 + (Left.Minutes * 60) + Left.Seconds;
                Num2 = (Right.Hours) * 3600 + (Right.Minutes * 60) + Right.Seconds;

                if (Num2 > Num1)
                {
                    return false;
                }
                else if (Num2 < Num1)
                {
                    return true;
                }
            }
            return false;
        }

        static public bool operator <(Duration Left, Duration Right)
        {
            int Num1 = 0, Num2 = 0;
            if ((Left is not null) & (Right is not null))
            {
                Num1 = (Left.Hours) * 3600 + (Left.Minutes * 60) + Left.Seconds;
                Num2 = (Right.Hours) * 3600 + (Right.Minutes * 60) + Right.Seconds;

                if (Num2 > Num1)
                {
                    return true;
                }
                else if (Num2 < Num1)
                {
                    return false;
                }
            }
            return false;
        }

        static public bool operator <=(Duration Left, Duration Right)
        {
            int Num1 = 0, Num2 = 0;
            if ((Left is not null) & (Right is not null))
            {
                Num1 = (Left.Hours) * 3600 + (Left.Minutes * 60) + Left.Seconds;
                Num2 = (Right.Hours) * 3600 + (Right.Minutes * 60) + Right.Seconds;

                if (Num2 >= Num1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        static public bool operator >=(Duration Left, Duration Right)
        {
            int Num1 = 0, Num2 = 0;
            if ((Left is not null) & (Right is not null))
            {
                Num1 = (Left.Hours) * 3600 + (Left.Minutes * 60) + Left.Seconds;
                Num2 = (Right.Hours) * 3600 + (Right.Minutes * 60) + Right.Seconds;

                if (Num2 <= Num1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool operator true(Duration duration)
        {
            int Num1 = (duration.Hours) * 3600 + (duration.Minutes * 60) + duration.Seconds;
            return Num1 != 0;
        }

        public static bool operator false(Duration duration)
        {
            int Num1 = (duration.Hours) * 3600 + (duration.Minutes * 60) + duration.Seconds;
            return Num1 == 0;
        }

        public static explicit operator DateTime(Duration duration)
        {
            DateTime X = DateTime.MinValue;
            X.AddHours(duration.Hours);
            X.AddMinutes(duration.Minutes);
            X.AddSeconds(duration.Seconds);
            return X;
        }
        #endregion


    }

    #endregion
}
