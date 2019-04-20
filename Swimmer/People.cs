using System;

namespace Swimmer
{
    public class People
    {
        // Общие данные
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string SwimmingWay { get; private set; }
        public int Distance { get; set; }

        // Конструктор с проверкой на входные данные
        public People(string name, string surname, string swimmingWay, int distance)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустыи");
            }
            else
            {
                Name = name;
            }

            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentNullException("Фамилия не может быть пустыи");
            }
            else
            {
                Surname = surname;
            }

            if (string.IsNullOrWhiteSpace(swimmingWay))
            {
                throw new ArgumentNullException("Вид плавания не может быть пустым, выберете кроль или брасс");
            }
            else
            {
                SwimmingWay = swimmingWay;
            }

            if (distance <= 0)
            {
                throw new ArgumentException("Такой дистанции нет, выберете 50, 100 или 200 метров");
            }
            else
            {
                Distance = distance;
            }
        }
    }
}
