using System;
namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fio = "Буничева Алёна Алексеевна";
            string group = "ИСП-242";
            bool run = true;

            while (run)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1 - Показать ФИО");
                Console.WriteLine("2 - Показать группу");
                Console.WriteLine("3 - Показать дату");
                Console.WriteLine("4 - Выход");

                Console.Write("\nВведите цифру: ");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine($"\nФИО: {fio}");
                        break;
                    case "2":
                        Console.WriteLine($"\nГруппа: {group}");
                        break;
                    case "3":
                        Console.WriteLine($"\nТекущая дата и время: {DateTime.Now}");
                        break;
                    case "4":
                        Console.WriteLine("\nДо свидания!");
                        run = false;
                        break;
                }
            }
        }
    }
}