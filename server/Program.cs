using System;
namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fio = "Буничева Алёна Алексеевна";
            string group = "ИСП-242";

            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine($"Разработчик: {fio}");
            Console.WriteLine($"Группа: {group}");
            Console.WriteLine($"Текущая дата и время: {DateTime.Now} ");
        }
    }
}