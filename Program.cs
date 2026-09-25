// int dayNumber = 7;
// switch (dayNumber)
// {
//     case 5 or 6 or 7: System.Console.WriteLine("Выходной"); break;
//     default: System.Console.WriteLine("Будний"); break;
// }

// int score =  101;
// switch (score)
// {
//     case >= 0 and <= 39: System.Console.WriteLine("Неудовлетворительно"); break;
//     case >= 40 and < 59: System.Console.WriteLine("Удовлетворительно"); break;
//     case >= 60 and < 79: System.Console.WriteLine("Хорошо"); break;
//     case >= 80 and <= 100: System.Console.WriteLine("Отлично"); break;
//     default: System.Console.WriteLine("Некорректный балл"); break;
// }

// int score = 30;
// string result = score switch
// {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     >= 35 => " Очень жарко",
// };
// System.Console.WriteLine(result);

// string role = "admin";
// string result = role switch
// {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" or not "teacher" => "Ограниченный доступ"
// };
// System.Console.WriteLine(result);

// int age = 20;
// bool hasTicket = true;
// switch (age)
// {
//     case >= 18 when hasTicket: System.Console.WriteLine("Вход разрешён"); break;
//     case >= 18: System.Console.WriteLine("Нет билета"); break;
//     default: System.Console.WriteLine("Возраст не подходит"); break;
// }

// int level = 2;
// switch (level)
// {
//     case 1: System.Console.WriteLine("Начальный уровень"); break;
//     case 2: System.Console.WriteLine("Средний уровень"); goto case 1;
//     case 3: System.Console.WriteLine("Продвинутый уровень"); break;    
// }

// // Задача А
// using System.Runtime.InteropServices;

// System.Console.Write("Номер месяца: ");
// int month = int.Parse(System.Console.ReadLine());
// string result = month switch
// {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// }; System.Console.WriteLine(result);

// // Задача Б
// System.Console.Write("Возраст: ");
// int age = int.Parse(System.Console.ReadLine());
// string result = age switch
// {
//     < 0 => "Ошибка",
//     >= 0 and <= 6 => "Ребёнок",
//     >= 7 and <= 17 => "Подросток",
//     >= 18 and <= 64 => "Взрослый",
//     >= 65 => "Пенсионер"
// }; System.Console.WriteLine(result);

// // Вариант 9 (25.09 я был на больничном, вариант выбрал с помощью колеса фортуны.)
// System.Console.Write("Час (0-23): ");
// int hour = int.Parse(System.Console.ReadLine());
// string result = hour switch
// {
//     >= 0 and <= 5 => "Ночной тариф",
//     >= 6 and <= 9 => "Утренний тариф",
//     >= 10 and <= 17 => "Дневной тариф",
//     >= 18 and <= 23 => "Вечерний тариф"
// }; System.Console.WriteLine(result);