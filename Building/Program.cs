using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Building
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Task 2");

            Console.WriteLine();
            Console.WriteLine("Введите высоту дома");
            uint height;
            while (!uint.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.WriteLine("Введите этажность дома");
            uint levels;
            while (!uint.TryParse(Console.ReadLine(), out levels))
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.WriteLine("Введите количество подъездов");
            uint countEntranence;
            while (!uint.TryParse(Console.ReadLine(), out countEntranence))
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.WriteLine("Введите количество квартир");
            uint countFlats;
            while (!uint.TryParse(Console.ReadLine(), out countFlats))
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.Clear();
            Console.WriteLine("Был построен новый дом!Доступна следующая информация:");
            House house = new House(height, levels, countEntranence, countFlats);
            house.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Высота этажа = " + house.GetHeightLevel().ToString());
            Console.WriteLine("Среднее кол-во квартир на подъезд = " + house.GetAvgFlatsInEntarances().ToString());
            Console.WriteLine("Среднее кол-во квартир на этаж = " + house.GetAvgFlatsOnLevel().ToString());

        }
    }
}

