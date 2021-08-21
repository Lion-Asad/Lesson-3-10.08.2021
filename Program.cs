using System;

namespace Lesson3
{
    class Program 
    {
        static void Main(string[] args)
        
        {
            // Задание 1

            int number = 1000;
            int res = number >= 500 && number < 1000 ? 3 : number < 500 ? 0 : 5;
            System.Console.WriteLine(number - number * res / 100);

            // Задание 2
            

            int a = 9;
            int b = 8;
            int c = 7;
            int d = 6;
            if ((a > b || a > c || a > d) || (b > c || b > d) || (c > d))
                Console.WriteLine("Числа расположены по возрастанию");
        
      
            // Задание 3
             int i = 10;
             int h = 12;
                int k = 13;
             int tmp = 0;
                if (k > h)
            {
            tmp = k;
            k = h;
            h = tmp;
            }
                 if (h > i)
            {
            tmp = i;
            i = h;
            h = tmp;
            }
                 if (k > h)
            {
            tmp = k;
            k = h;
            h = tmp;
            }
            System.Console.WriteLine(i+":"+h+":"+k);
        }
    }
}
