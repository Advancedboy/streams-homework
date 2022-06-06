using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Streams_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Добавление нового пользователя.");
            Console.WriteLine("Введите ваше имя: ");
            var Name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            var SecondName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            var Age = Console.ReadLine();
            Console.WriteLine("Введите ваш вес: ");
            var Weight = Console.ReadLine();
            Console.WriteLine("Записываем данные в файл...");
            Console.WriteLine("Нажмите Enter для продолжения...");
            Console.ReadLine();
            using (var sw = new StreamWriter("User.txt", true, Encoding.UTF8))
            {
                sw.WriteLine("================");
                sw.WriteLine($"Name: {Name}.");
                sw.WriteLine($"SecondName: {SecondName}.");
                sw.WriteLine($"Age: {Age}.");
                sw.WriteLine($"Weight: {Weight}.");
            }
         
            while (true)
            {
                Console.WriteLine("Чтобы посмотреть список пользователей нажмите YY.");
                var Accept = Console.ReadLine();
                if (Accept == "YY")
                {
                    CheckUser();
                    break;
                }
            }
            Console.ReadLine();
        }

        static void CheckUser()
        {
            using (var sr = new StreamReader("User.txt", Encoding.UTF8))
            {
                Console.WriteLine("Users:------");
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                Console.WriteLine("================");
            }
        }
    }
}
