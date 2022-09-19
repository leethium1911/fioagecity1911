using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fio = { "Гоголь Николай Васильевич", "Шмелев Иван Сергеевич", "Лермонтов Михаил Юрьвич", "Пушкин Александр Сергеевич", "Есенин Сергей Александрович", "Достоевский Федор Михайлович", "Маяковский Владимир Владимирович" };
            int[] age = { 17, 19, 21, 23, 25, 27, 29 };
            string[] city = {"Москва", "Санкт-Петербург", "Казань", "Нижний Новгород", "Самара", "Владивосток"};
                                    
               

            void FioAgeCity()
            {
                Random z = new Random();              
                int c = z.Next(7);
                int v = z .Next(7);
                int s = z .Next(6);

                //Console.WriteLine(c);
                //Console.WriteLine(v);
                //Console.WriteLine(s);

                if (c < fio.Length && v < age.Length && s < city.Length)
                    Console.WriteLine("Имя - " + fio[c] + ". Возраст - " + age[v] + ". Место рождения - " + city[s] + ".");
            }
            Console.WriteLine("Список человеков:");

            FioAgeCity();
            FioAgeCity();
            FioAgeCity();

        }
    }
}
