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
                return; // возвращает куда-то?????
            }

            var dates = GetDates(); // переменная dates обращается к названию метода GetDates
            FindAndShowSuitableDates(dates, day); //название метода FindAndShowSuitableDates хранит в себе переменные dates, day

            Console.ReadKey(); // Для чего тут ввод в консоль?? 
        }
        private static (bool isCorrect, Week day) InputAndCheckUserData() //создаем булевую переменную isCorrect и Week day и называем все это функцией InputAndCheckUserData
        {
            Console.WriteLine("Input Value: "); //просим ввести пользователя значение
            var userImput = Console.ReadLine(); //создаем неизвестную переменную userImput и приравниваем ей то что ввели в консоль
            return CheckUserImput(userImput); //передаем переменную UserImput в функцию CheckUserImput (Можно ли назвать ее методом?)
        }
        private static (bool isCorrect, Week day) CheckUserImput(string userImput)//зачем тут (bool isCorrect, Week day) ???? 
        {
            return userImput switch //возвращает сюда переменную userImput и с помощью оператора switch проверяет корректность ввода, логика работы switch описана ниже
            {
                "Monday" => (true, Week.Monday),
                "Tuesday" => (true, Week.Tuesday),
                "Wednesday" => (true, Week.Wednesday),
                "Thursday" => (true, Week.Thursday),
                "Friday" => (true, Week.Friday),
                "Saturday" => (true, Week.Saturday),
                "Sunday" => (true, Week.Sunday),
                _ => (false, Week.Unknown), // обязательно нужно использовать нижнее подчеркивание для указания примера некорректного ввода? 
            };
        }
        private static DateTime[] GetDates() //создается функция которая называется GetDates в которую входит библиотека DateTime??
        {
            var currentMonth = DateTime.Now.Date.Month;// в переменную неизвестного типа currentMonth, мы помещаем данные из библиотеки DateTime о текущем месяце
            var currentYear = DateTime.Now.Date.Year;// в переменную неизвестного типа currentYear, мы помещаем данные из библиотеки DateTime о текущем году
            var daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);// в переменную неизвестного типа daysInMonth мы помещаем данные функции библиотеки DateTime.DaysInMonth??? 

            var dates = new DateTime[31]; //в переменную неизвестного типа date мы помещаем обьект?? (т,е это есть конструктор) как это работает в данном случае?? задаем 31 день?? Как работают квадратные скобки???
            for (int i = 1; i < daysInMonth + 1; i++) // используем цикл for в котором инициализируем переменную i, приравниваем ей 1, проверяем меньше ли эта еденица дня месяца и прибавляем 1?? зачем инкремент переменной i???
            {
                dates[i] = new DateTime(currentYear, currentMonth, i); // не понимаю как работают квадратные скобки, создается обьект из перечени переменных currentYear, currentMonth, i и помещается в dates???
            }

            return dates; // возвращаемся из цикла на 59 строчку кода? 
        }

        private static void FindAndShowSuitableDates(DateTime[] dates, Week day)
        {
            foreach (var date in dates) // foreach получает переменную date и dates (dates уже с данными т.к на 53 строчке когда над ними поработала функиця GetDates???)
            {
                if (date != DateTime.MinValue && date.DayOfWeek.ToString() == day.ToString())// если переменная date не равна (DateTime.MinValue?? не совсем понял что это) и date это день недели который есть в библиотеке сверяется с вписанным пользователем днем недели day верна, то выводится в консоль дата??
                {
                    Console.WriteLine(date);
                }
            }
        }
    }

}
