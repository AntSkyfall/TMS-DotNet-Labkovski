using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи дату: "); // выводит в консоль текст для информативности
            string input = Console.ReadLine(); // инициализация переменной оператором присваивания с помощью ввода в консоль
            bool condition = DateTime.TryParse(input, out DateTime result); // проверяю на корректность введенных данных. результат - правда/ложь... 
            // Инициализирую переменную буллевого типа c помощью оператора присваивания результатом метода Tryparse
            if (condition) // если condition truе то работает блок if, если condition false то работает блок else 
            {
                Console.Write("Ввод корректный: " + result.DayOfWeek + " " + result.DayOfYear ); // вывожу в консоль текст и значения свойства DayOfWeek и DayOfYear
            }
            else
            {
                Console.Write("некорректный ввод: "); // вывожу тест о ошибке
            }
        }
    }
}          
           