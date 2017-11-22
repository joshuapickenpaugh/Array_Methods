//Joshua Pickenpaugh
//Array Methods
//November 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables:
            List<double> lstDouble = new List<double>();
            double dblUserNum = 0;
            Boolean bolLoopControl = true;
            string strLoopControl;

            //Greeting:
            Console.WriteLine("Enter a number or 'X' to quit number entry: ");

            //User input:
            do
            {
                //User input:
                Console.Write("--->: ");

                strLoopControl = Console.ReadLine();
                if (strLoopControl == "X" || strLoopControl =="x")
                {
                    bolLoopControl = false;
                }
                else
                {
                    dblUserNum = Convert.ToDouble(strLoopControl);
                    lstDouble.Add(dblUserNum);
                }
            }
            while (bolLoopControl == true);

            //Methods:
            DisplayArray(lstDouble);
            DisplayInReverse(lstDouble);

            //Exiting program:
            Console.WriteLine("Press any key to EXIT PROGRAM.");
            Console.ReadKey();
        }

        public static void DisplayArray(List<double> lstDbl)
        {
            Console.WriteLine("_______");
            Console.WriteLine("Array: ");
            foreach (double number in lstDbl)
            {
                Console.WriteLine(number);
            }
        }

        public static void DisplayInReverse(List<double> lstDbl)
        {
            Console.WriteLine("_______");
            Console.WriteLine("Array in Reverse Order: ");
            lstDbl.Reverse();
            foreach (double number in lstDbl)
            {
                Console.WriteLine(number);
            }
        }
    }
}