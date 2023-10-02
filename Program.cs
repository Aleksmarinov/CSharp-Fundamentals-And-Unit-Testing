using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversation
            int num = 1235948642;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // explicit conversation
            // cast double to int
            myInt = (int)myDouble;

            // type conversation
            string myString = myDouble.ToString(); // "13,37"
            string myNewString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
       
}
