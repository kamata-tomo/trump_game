using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i <4; i++)
            {
                while (true)
                {
                    Console.WriteLine($"{i+1}番目のカードを入力してください(1-4) > ");

                    if(!int.TryParse(Console.ReadLine(), out int input))
                    {
                        Console.WriteLine("1-4の数字を入力してください");
                        
                        continue;
                    }
                    if (input < 1 || input > 4)
                    {
                        Console.WriteLine("1-4の間で数字を入力してください");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
