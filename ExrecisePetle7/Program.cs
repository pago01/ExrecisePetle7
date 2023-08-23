using System;
using System.ComponentModel.Design;

namespace ExercisePetle6
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a = 0;
            string b = "";
            Console.WriteLine("Podaj dlugosc przekatnej");
            Int32.TryParse(Console.ReadLine(), out a);
            //Calculation and drawing
                // Upper part and horizontal diagonal
                for(int i = a % 2; i <=a; i=i+2)                    
                {
                    b = "";
                    for (int j = 1; j <= (a-i)/2; j++)
                    {
                        b = b + " ";
                    }
                    for (int j = 1; j <=i; j++)
                    {
                        b = b + "*";
                    }
                    Console.WriteLine(b);
                }
                //Lower part
                for (int i = a-2; i >= 1; i=i-2)
                {
                    b = "";                   
                    for (int j = 1; j <= (a-i)/2; j++)
                    {
                        b = b + " ";
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        b = b + "*";
                    }
                    Console.WriteLine(b);
                }
        }
    }
}