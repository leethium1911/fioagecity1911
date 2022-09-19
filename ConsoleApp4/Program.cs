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
                                    
               

            void FioAgeCity(string fio, int age, string city)
            {           

                Console.WriteLine("Имя - " + fio + ". Возраст - " + age + ". Место рождения - " + city + ".");
            }
            Console.WriteLine("Список человеков:");
            Random z = new Random();
            FioAgeCity(fio[z.Next(7)], age[z.Next(7)], city[z.Next(6)]);
            FioAgeCity(fio[z.Next(7)], age[z.Next(7)], city[z.Next(6)]);
            FioAgeCity(fio[z.Next(7)], age[z.Next(7)], city[z.Next(6)]);



        }
    }
}
