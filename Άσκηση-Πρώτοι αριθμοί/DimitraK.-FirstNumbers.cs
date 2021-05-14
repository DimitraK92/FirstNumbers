using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Άσκηση_Πρώτοι_αριθμοί
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] firstNumbers = new int[size];
            int counter = 0;
            int x = 2;
            while (counter < size)
            {
                bool isFirstNumber = true;
                for (int i = 2; i < x - 1; i++)
                {
                    if (x % i == 0)
                    {
                        isFirstNumber = false;
                        break;
                    }
                }
                if (isFirstNumber)
                {
                    firstNumbers[counter] = x;                  
                    counter++;
                }
                x++;
            }
            for (int i=0; i<firstNumbers.Length; i++)
            {
                Console.WriteLine((i+1) + " : " + firstNumbers[i]);
            }           
            Console.ReadKey();
        }
    }
}
