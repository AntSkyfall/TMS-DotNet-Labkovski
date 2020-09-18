using System;

namespace HomeWork2
{
    class Program
    {
        enum Week //перечисляем дни недели и присваиваем им интовое значение.
        {
            Unknown,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Main(string[] args)
        {
            var (isCorrect, day) = InputAndCheckUserData(); //инициализируем неизвестные переменные и приравниваем им inputAndCheckUserData
            if (!isCorrect) //выводим сообщение об ошибке если введенные данные не корректны
            {
                Console.WriteLine("The enterred data is incorrected"); // выводится в консоль сообщение о некорректности ввода
                Console.ReadKey(); // для того что бы консоль не закрылась
                return; // заканчивает функцию Main
            }

            var dates = GetDates(); // переменная dates обращается к методу GetDates
            FindAndShowSuitableDates(dates, day); //метод FindAndShowSuitableDates хранит в себе переменные dates, day

            Console.ReadKey(); // для того что бы консоль не закрылась.
        }
        private static (bool isCorrect, Week day) InputAndCheckUserData() //создаем булевую переменную isCorrect и Week day и называем все это методом InputAndCheckUserData
        {
            Console.WriteLine("Input Value: "); //просим ввести пользователя значение
            var userImput = Console.ReadLine(); //создаем неизвестную переменную userImput и приравниваем ей то что ввели в консоль
            return CheckUserImput(userImput); //передаем переменную UserImput в метод CheckUserImput
        }
        private static (bool isCorrect, Week day) CheckUserImput(string userImput)//
        {
            return userImput switch //возвращает кортежи bool и Week сверяет стринговый userimput с литералами
            {
                "Monday" => (true, Week.Monday),
                "Tuesday" => (true, Week.Tuesday),
                "Wednesday" => (true, Week.Wednesday),
                "Thursday" => (true, Week.Thursday),
                "Friday" => (true, Week.Friday),
                "Saturday" => (true, Week.Saturday),
                "Sunday" => (true, Week.Sunday),
                _ => (false, Week.Unknown),
            };
        }
        private static DateTime[] GetDates() //создается функция которая называется GetDates она возвращает массив DateTime
        {
            var currentMonth = DateTime.Now.Date.Month;// в переменную неизвестного типа currentMonth, мы помещаем данные из класса DateTime о текущем месяце
            var currentYear = DateTime.Now.Date.Year;// в переменную неизвестного типа currentYear, мы помещаем данные из класса DateTime о текущем году
            var daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);// в переменную неизвестного типа daysInMonth мы помещаем данные о днях в текущем году и месяце

            var dates = new DateTime[31]; //в переменную dates мы помещаем массив типа DataTime
            for (int i = 1; i <= daysInMonth; i++) // используем цикл for в котором инициализируем переменную i, приравниваем ей 1, проверяем меньше ли эта еденица дня месяца и прибавляем 1, инкремент i для продвижения по числам
            {
                dates[i] = new DateTime(currentYear, currentMonth, i); // заполняем массив dates
            
            return dates; //возвращаем массив
        }

        private static void FindAndShowSuitableDates(DateTime[] dates, Week day) //создаем метод и указываем его параметры
        {
            foreach (var date in dates) //форич перебирает элементы массива dates + создана переменная date
            {
                if (date != DateTime.MinValue && date.DayOfWeek.ToString() == day.ToString())// сравнивает элементы массива с вводом пользователя.
                {
                    Console.WriteLine(date); //выводит в консоль.
                }
            }
        }
    }

}
