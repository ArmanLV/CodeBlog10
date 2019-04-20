using System;
using System.Collections.Generic;
using System.Text;

namespace Swimmer
{
    class Swimmer
    {
        static void Main(string[] args)
        {
            //Получение данных
            Console.WriteLine("Введите ваше имя");
            string Name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string Surname = Console.ReadLine();

            Console.WriteLine("Выберете стиль плавания: кроль или брасс?");
            string SwimmingWay = Console.ReadLine();

            Console.WriteLine("Выберете расстояние: 50, 100 или 200 метров");
            int Distance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер числа Фибоначчи");
            int FibonachiNumber = Convert.ToInt32(Console.ReadLine());

            // Обьявление экземпляров
            People SwimmerOne = new People(Name, Surname, SwimmingWay, Distance);
            People SwimmerTwo = new People("Пётр", "Первый", SwimmingWay, Distance);

            // Вывод числа Фибоначчи по номеру          
            Console.WriteLine($"Число фиббоначи {FibonachiNumber}: {Fibonachi(FibonachiNumber)}");

            // Рандомное время плавцов
            int SwimmerOneTime = SwimmingTime(SwimmerOne.SwimmingWay, SwimmerOne.Distance);
            int SwimmerTwoTime = SwimmingTime(SwimmerTwo.SwimmingWay, SwimmerTwo.Distance);

            // Вывод результатов
            Console.WriteLine($"{SwimmerOne.Name} {SwimmerOne.Surname} проплыл {SwimmerOne.Distance}м видом {SwimmerOne.SwimmingWay} за {SwimmerOneTime} секунд");
            Console.WriteLine($"{SwimmerTwo.Name} {SwimmerTwo.Surname} проплыл {SwimmerTwo.Distance}м видом {SwimmerTwo.SwimmingWay} за {SwimmerTwoTime} секунд");

            // Обьявление попедителя
            if (SwimmerOneTime < SwimmerTwoTime)
            {
                Console.WriteLine($"Победил {SwimmerOne.Name} {SwimmerOne.Surname} с отрывом в {SwimmerTwoTime - SwimmerOneTime} секунд!");
            }
            else if (SwimmerOneTime == SwimmerTwoTime)
            {
                Console.WriteLine($"Ничья! с результатом в {SwimmerOneTime} секунд");
            }      
            else if (SwimmerOneTime == 0 || SwimmerTwoTime == 0)
            {
                throw new ArgumentException("Что-то пошло не так");
            }
            else
            {
                Console.WriteLine($"Победил {SwimmerTwo.Name} {SwimmerTwo.Surname} с отрывом в {SwimmerOneTime - SwimmerTwoTime} секунд!");
            }

            Console.ReadLine();
        }

        // Метод поиска числа Фибоначчи по номеру через рекурсию
        static int Fibonachi(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else if (value == 2)
            {
                return 1;
            }
            else
            {
                return Fibonachi(value - 2) + Fibonachi(value - 1);
            }
        }

        // Метод рандомного (Приблизительного) результата, исходя из дистанции и вида плавания
        static int SwimmingTime(string _swimmingType, int _distance)
        {
            if (_swimmingType == "кроль")
            {
                if (_distance == 50)
                {
                    return new Random().Next(21, 54);
                }
                else if (_distance == 100)
                {
                    return new Random().Next(47, 123);
                }
                else if (_distance == 200)
                {
                    return new Random().Next(104, 265);
                }
            }

            if (_swimmingType == "брасс")
            {
                if (_distance == 50)
                {
                    return new Random().Next(26, 65);
                }
                else if (_distance == 100)
                {
                    return new Random().Next(58, 143);
                }
                else if (_distance == 200)
                {
                    return new Random().Next(128, 305);
                }
            }
            return 0;
        }
    }
}
