using System;
using System.Collections.Generic;

namespace Hjort
{
    public enum DickType
    {
        Cocks,
        Towers,
        Chunkers,
        PhattOnes,
        HottOnes
    }
    internal class Program
    {

        public static void Main(string[] args)
        {
            string[] dillerNavne = {"Klokketårn","Enøjet Slange","Slampumpe" };
            
            List<string> cockList = new();
            Console.WriteLine("Input COCK NAME to add to the list");
            cockList.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("go to take a piss");

            cockList.AddRange(dillerNavne);

            cockList.Remove("Klokketårn");

            Console.WriteLine(cockList);

            string? Slange = cockList.Find(x => x.Contains("slange"));

            double FUCK = double.NaN;


            Dictionary<DickType, double> penisDic = new(); // Type of COCK, length of COCK
            penisDic.Add(DickType.Cocks, 21.3);

            Point2D 
                PointA = new(),
                PB = new();

            PointA.X = 69;
            PointA.Y = 420;

            PB.X = 4;
            PB.Y = 5;

            Console.WriteLine(PointA.Distance(PB));

            Point2D XU = new();
            XU.X = 60;
            XU.Y = 40;

            Console.WriteLine(PointA.Distance(PB));



        Retry:
            try
            {
                int UserInput = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("YOU DOMB FUK, THIS NEED NUMBER!");
                goto Retry;
            }
        }

        public static void goToTakeAPiss()
        {
            Console.WriteLine("Oh shit, im sorry");
            Sorennu.PortaPotty potty = new();
        }

        
    }
}
namespace Hjort
{
    public class PortaPotty
    {
        public string goks()
        {

            return "goks";
        }

    }

    public class Point2D
    {
        public double X;
        public double Y;

        public string[] PartList;

        public double Distance(Point2D PointB)
        {
            double 
                xDiff = this.X - PointB.X,
                yDiff = this.Y - PointB.Y;

            return xDiff + yDiff;

        }
       
    }
}
