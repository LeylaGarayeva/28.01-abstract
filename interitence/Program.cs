using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interitence
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetCursorPosition(5,5);
            //Console.Write("+");
            //Console.SetCursorPosition(7, 5);
            //Console.Write("+");
            //Console.SetCursorPosition(9, 5);
            //Console.Write("+");
            //Console.SetCursorPosition(11, 5);
            //Console.Write("+");
            //Console.SetCursorPosition(13, 5);
            //Console.Write("+");

            //Console.SetCursorPosition(5, 6);
            //Console.Write("+");
            //Console.SetCursorPosition(5, 7);
            //Console.Write("+");
            //Console.SetCursorPosition(5, 8);
            //Console.Write("+");
            //Console.SetCursorPosition(5, 9);
            //Console.Write("+");

            //Console.SetCursorPosition(7, 9);
            //Console.Write("+");
            //Console.SetCursorPosition(9, 9);
            //Console.Write("+");
            //Console.SetCursorPosition(11, 9);
            //Console.Write("+");
            //Console.SetCursorPosition(13, 9);
            //Console.Write("+");

            //Console.SetCursorPosition(13, 6);
            //Console.Write("+");
            //Console.SetCursorPosition(13, 7);
            //Console.Write("+");
            //Console.SetCursorPosition(13, 8);
            //Console.Write("+");



           for (int l = 1; l <= 8; l++) { 

            for(int i = 5; i <= 13; i += 2)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write("+");
                Console.SetCursorPosition(i, 9);
                Console.Write("+");
            }


            for(int j = 6; j <= 9; j++)
            {
                Console.SetCursorPosition(5, j);
                Console.Write("+");
                Console.SetCursorPosition(13, j);
                Console.Write("+");
            }


            }

        
            //SunSystem sunSystem = new SunSystem();
            //Earth eath = new Earth();
            //sunSystem.starname = int.Parse(Console.ReadLine());
            //Console.WriteLine("Starnemi elave edin: " + sunSystem.starname);
            //sunSystem.planets = Console.ReadLine();
            //eath.starname = int.Parse(Console.ReadLine());
            //eath.planets = Console.ReadLine();
            //eath.diametr =int.Parse(Console.ReadLine());
            //eath.shapeForm = Console.ReadLine();
            //eath.distanceFromSun = int.Parse(Console.ReadLine());
            //eath.qonsular = Console.ReadLine().Split(',');
            //Console.WriteLine("qonsu:" + string.Join(",",eath.qonsular));

            Console.ReadLine();
        }
    }

    interface IPlanet
    {
         bool rotation();
         string getCoordinates();
    }

     abstract class Galaxy
    {

        public int stars;
        public int lenght;
        public int width;

       virtual public int printDetails()
        {
            return stars;
        }
    }

    class SunSystem : Galaxy
    {
        public int starname;
        public string planets;

        override public int printDetails()
        {
            return starname;
        }
    }

    class Earth : SunSystem,IPlanet
    {
       
        public int diametr;
        public string shapeForm;
        public int distanceFromSun;
        public string[] qonsular;

        public string getCoordinates()
        {
            throw new NotImplementedException();
        }

        public bool rotation()
        {
            throw new NotImplementedException();
        }

        override public int printDetails()
        {
            return 0;
        }
    }




}
