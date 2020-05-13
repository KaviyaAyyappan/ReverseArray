using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter the number:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reverse Array");
            int[] temp = array;
            Array.Reverse(temp);
            foreach (int j in temp)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
