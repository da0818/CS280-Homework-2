using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入一隻Pokemon");

            Console.Write("請輸入Name:");
            string Name = Console.ReadLine();

            int NationalNo = 0;
            int Height = 0;
            int Weight = 0;
            Console.Write("請輸入NationalNo:");
            try
            {
                NationalNo = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Height:");
            try
            {
                Height = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Weight:");
            try
            {
                Weight = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("請輸入Abilities:");
            string Abilities = Console.ReadLine();
            Console.Write("請輸入Category:");
            string Category = Console.ReadLine();
            Console.Write("請輸入Gender:");
            string Gender = Console.ReadLine();

            Console.WriteLine("名字:{0}, 編號{1}, 身高{2}, 體重{3}, 能力{4}, 類別{5}, 性別{6}",
                Name, NationalNo, Height, Weight, Abilities, Category, Gender);
        }
    }
}