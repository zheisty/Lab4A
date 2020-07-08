using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Lab4A
{
    class Program
    {
        static void Main(string[] args)
        {
            // number of days is 7
            // temperature in celsius per day is input
            // calculate temperature in f per day
            // calculate the sum in f
            // calculate average temp in f

            int[] Celsius = new int [7];
            double[] farenheit = new double[7];
           

            for (int pos = 0; pos < Celsius.Length; pos++)
            {
                Console.WriteLine("Enter temperature in Celsius"); 
                Celsius[pos]= Convert.ToInt32(Console.ReadLine());
                farenheit[pos] = Convert.ToDouble((Celsius[pos] * 9 / 5) + 32);
                
            }




            Console.WriteLine("Temperature in Farenheit");

            Array.Reverse(farenheit);
            foreach (double i in farenheit)
            {
                Console.WriteLine(i);
            }

           
        }

    }
}
