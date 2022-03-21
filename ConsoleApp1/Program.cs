using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         //   int guess=0;
            int i = 5;
            int max = 100;
            int min = 0;
            string num= Console.ReadLine();
            Random ranNum = new Random();
            int ans = ranNum.Next(0, 100);
            Console.Write(ans);
           // guess = Convert.ToInt32(num);
            while (i > 0)
            {
                int guess = int.Parse(Console.ReadLine());
                i--;
                if(guess > ans)
                {
                    max = guess;
                    Console.Write("猜錯，介於"+min+"到"+max+"，還有"+i+"次");
                }
                if (guess < ans)
                {
                    min = guess;
                    Console.Write("猜錯，介於" + min + "到"+max+"，還有" + i + "次");
                }
                if (guess == ans)
                {
                    Console.Write("答對");
                    break;
                }
            }
        }
    }
}
