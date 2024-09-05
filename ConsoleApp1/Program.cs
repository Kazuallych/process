////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");


////// 6 задание
////using System;
////namespace PrimeNumbers
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Console.Write("Введите верхнюю границу диапазона:");

////            if (!int.TryParse(Console.ReadLine(), out int n))
////            {
////                Console.WriteLine("Некорректный ввод. Введите целое число.");
////                return;
////            }
////            if (n < 2)
////            {
////                Console.WriteLine("Введите число больше 1.");
////                return;
////            }
////            Console.WriteLine("Простые числа в диапазоне от 1 до {0}:, n");
////            for (int i = 2; i <= n; i++)
////            {
////                if (IsPrime(i))
////                {
////                    Console.Write("{0}", i);
////                }
////            }
////            Console.WriteLine();
////        }
////        static bool IsPrime(int number)
////        {
////            if (number <= 1)
////            {
////                return false;
////            }
////            for (int i = 2; i * i <= number; i++)
////            {
////                if (number % i == 0)
////                {
////                    return false;
////                }
////            }
////            return true;
////        }
////    }
////}








////using System;
////namespace GuessTheNumber
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Random random = new Random();
////            int secretNumber = random.Next(1, 101);
////            Console.WriteLine("Добро пожаловать в игру 'Угадай число' !");
////            Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать.");
////            int at = 0;
////            bool gue = false;
////            while (!gue)
////            {
////                Console.Write("Введите ваше число:");
////                if (!int.TryParse(Console.ReadLine(), out int guess))
////                {
////                    Console.WriteLine("Некорректный ввод. Введите целое число");
////                    continue;
////                }
////                attempts++;
////                if (guess < secretNumber)
////                {
////                    Console.WriteLine("Слишком мало. Попробуйте еще раз.");
////                }
////                else if (guess > secretNumber)
////                {
////                    Console.WriteLine("Слишком много. Попробуйте еще раз.");
////                }
////                else
////                {
////                    gue = true;
////                    Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток!", attempts);
////                }
////            }
////        }
////    }
////}







////7 задание
////using System;

////class GuessNumberGame
////{
////    static void Main()
////    {
////        Random random = new Random();
////        int numberToGuess = random.Next(1, 101); // Генерация случайного числа от 1 до 100
////        int numberOfTries = 0;
////        bool hasGuessedCorrectly = false;

////        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
////        Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать его!");

////        while (!hasGuessedCorrectly)
////        {
////            Console.Write("Введите ваше предположение: ");
////            string userInput = Console.ReadLine();

////            // Проверка, является ли ввод числом
////            if (int.TryParse(userInput, out int userGuess))
////            {
////                numberOfTries++;

////                if (userGuess < 1 || userGuess > 100)
////                {
////                    Console.WriteLine("Пожалуйста, введите число в диапазоне от 1 до 100.");
////                }
////                else if (userGuess < numberToGuess)
////                {
////                    Console.WriteLine("Слишком низко! Попробуйте еще раз.");
////                }
////                else if (userGuess > numberToGuess)
////                {
////                    Console.WriteLine("Слишком высоко! Попробуйте еще раз.");
////                }
////                else
////                {
////                    hasGuessedCorrectly = true;
////                    Console.WriteLine($"Поздравляю! Вы угадали число {numberToGuess} за {numberOfTries} попыток.");
////                }
////            }
////            else
////            {
////                Console.WriteLine("Пожалуйста, введите корректное число.");
////            }
////        }
////    }
////}





//using System;

//namespace AreaCalculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Калькулятор площади фигур");
//            Console.WriteLine("Выберите фигуру:");
//            Console.WriteLine("1. Круг");
//            Console.WriteLine("2. Треугольник");
//            Console.WriteLine("3. Прямоугольник");

//            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 3)
//            {
//                Console.WriteLine("Некорректный выбор. Пожалуйста, выберите число от 1 до 3.");
//                return;
//            }

//            switch (choice)
//            {
//                case 1:
//                    CalculateCircleArea();
//                    break;
//                case 2:
//                    CalculateTriangleArea();
//                    break;
//                case 3:
//                    CalculateRectangleArea();
//                    break;
//            }
//        }

//        static void CalculateCircleArea()
//        {
//            Console.Write("Введите радиус круга: ");
//            if (!double.TryParse(Console.ReadLine(), out double radius))
//            {
//                Console.WriteLine("Некорректный ввод. Введите число.");
//                return;
//            }

//            double area = Math.PI * Math.Pow(radius, 2);
//            Console.WriteLine("Площадь круга: {0:F2}", area);
//        }

//        static void CalculateTriangleArea()
//        {
//            Console.Write("Введите основание треугольника: ");
//            if (!double.TryParse(Console.ReadLine(), out double baseLength))
//            {
//                Console.WriteLine("Некорректный ввод. Введите число.");
//                return;
//            }

//            Console.Write("Введите высоту треугольника: ");
//            if (!double.TryParse(Console.ReadLine(), out double height))
//            {
//                Console.WriteLine("Некорректный ввод. Введите число.");
//                return;
//            }

//            double area = 0.5 * baseLength * height;
//            Console.WriteLine("Площадь треугольника: {0:F2}", area);
//        }

//        static void CalculateRectangleArea()
//        {
//            Console.Write("Введите длину прямоугольника: ");
//            if (!double.TryParse(Console.ReadLine(), out double length))
//            {
//                Console.WriteLine("Некорректный ввод. Введите число.");
//                return;
//            }

//            Console.Write("Введите ширину прямоугольника: ");
//            if (!double.TryParse(Console.ReadLine(), out double width))
//            {
//                Console.WriteLine("Некорректный ввод. Введите число.");
//                return;
//            }

//            double area = length * width;
//            Console.WriteLine("Площадь прямоугольника: {0:F2}", area);
//        }
//    }
//}

//using System.Diagnostics;
//using System.Security.Cryptography;

//Process[] processes = Process.GetProcesses();

//foreach (Process process in processes)
//{
//    Console.Write("Name: " + process.ProcessName + "\tId: " + process.Id + "\tRAM: " + process.PagedMemorySize + "\tStatus: ");
//    if (process.ProcessName.Length == 0)
//    {
//        Console.Write("Не робит");
//    }
//    else
//    {
//        Console.Write("Робит");
//    }
//    Console.WriteLine();
//}
//Console.Write("Введи ID процесса который хотите завершить: ");
//int pid = int.Parse(Console.ReadLine());
//Process p = Process.GetProcessById(pid);
//Logger.Logging("Процесс убит " + p.ProcessName);
//p.Kill();

//Console.Write("Напишите название чтобы запустить программу: ");
//string path = Console.ReadLine();
//Process.Start(path);

//Logger.Logging("Процесс запущен");

//class Logger
//{
//    public static void Logging(string message)
//    {
//        string logPath = "process_log.txt";

//        using (StreamWriter sw = new StreamWriter(logPath, true))
//        {
//            sw.WriteLine($"{DateTime.Now} {message}");
//        }
//    }
//}


using System.Diagnostics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
Store store = new Store();

while (true)
{
    Console.WriteLine("Выберите действие\n1.Добавить товар\n2.Просмотреть список товаров\n3.Найти товар по названию\n4.Продать товар\n5.Выход из программы");
    int choose = int.Parse(Console.ReadLine());

    switch (choose)
    {
        case 1:
            Console.Write("Название товара: ");
            string name = Console.ReadLine();
            Console.Write("Цена товара: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Количество товара: ");
            int count = int.Parse(Console.ReadLine());
            store.NewProduct(name, price, count);
            break;
        case 2:
            store.List();
            break;
        case 3:
            Console.Write("Введите название товара: ");
            string name1 = Console.ReadLine();
            store.Search(name1);
            break;
        case 4:
            Console.WriteLine("Введите название товара, который хотите продать: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите сколько товара вы хотите продать: ");
            int count1 = int.Parse(Console.ReadLine());
            store.ChangeCount(name2, count1);
            break;
        case 5:
            Environment.Exit(0);
            break;
    }
    Console.WriteLine();
}



struct Product()
{
    public string name;
    public double price;
    public int count;
    public Product NewProduct(string _name, double _price, int _count)
    {
        name = _name;
        count = _count;
        price = _price;
        return this;
    }
    public void ChangePrice(double _price)
    {
        price = _price ;
    }
    public void ChangeCount(int _count)
    {
        count -= _count;
        Console.WriteLine($"Осталось продуктов: {count}");
    }


}


class Store()
{
    List<Product> products = new List<Product>();

    public void NewProduct(string name, double price, int count)
    {
        products.Add(new Product().NewProduct(name, price, count));
    }

    public void List()
    {
        foreach (Product p in products)
        {
            Console.WriteLine($"Название:{p.name}|Цена:{p.price}|Количество:{p.count}");
        }
    }

    public void Search(string name)
    {
        foreach (Product p in products)
        {
            if(name==p.name)
            {
                Console.WriteLine($"Название:{p.name}|Цена:{p.price}|Количество:{p.count}");
                break;
            }
        }
    }

    public void ChangeCount(string name, int count)
    {
        foreach(Product p in products)
        {
            if(p.name==name)
            {
                p.ChangeCount(count);
            }
        }
    }
}






