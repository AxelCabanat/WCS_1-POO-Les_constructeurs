using System;

namespace WCS_1_POO_Les_constructeurs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many floor have your building");
            string myfloor = Console.ReadLine() ;
            double parsedMyFloor;

            while( !double.TryParse(myfloor, out parsedMyFloor))
            {
                Console.WriteLine("I need an interger");
                myfloor = Console.ReadLine();
            }

            Console.WriteLine("How size have your building");
            string mysize = Console.ReadLine();
            double parsedMySize;
            Building myBuilding;
            if ( double.TryParse(mysize, out parsedMySize))
            {
                 myBuilding = new Building(parsedMyFloor, parsedMySize);
            }
            else
            {
                myBuilding = new Building(parsedMyFloor);
            }

            
            double floorMaxsize = myBuilding.GetFloorMaxsize();
            double floorCount = myBuilding.GetFloorCount();
            double buildingSize = myBuilding.GetSize();


            Console.WriteLine("floorMaxsize = " + floorMaxsize);
            if (floorMaxsize < 3)
            {
                Console.WriteLine("Maybe your building should be taller");
            }
            Console.WriteLine("floorCount = " + floorCount);
            Console.WriteLine("buildingSize = " + buildingSize);

            Console.ReadKey();
        }

        public class Building
        {
            private double _height;
            private double _floor;

            public Building(double floor)
            {
                _floor = floor;
                _height = Math.Floor(floor * 3);
            }
            public Building(double floor, double size)
            {
                _floor = floor;
                _height = size;
            }
            public double GetFloorMaxsize()
            {
                return _height / _floor;
            }
            public double GetFloorCount()
            {
                return _floor;
            }
            public double GetSize()
            {
                return _height;
            }
        }
    }
}
