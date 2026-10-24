// Задание 1
// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// int count = 0;
// string lower = word.ToLower();
// foreach (char c in lower)
// {
//     if (c == 'а') count++;
// }
// Console.WriteLine($"Буква 'а' встречается {count} раз(а)");
// Задание 2
// Console.Write("Введите имя файла: ");
// string file = Console.ReadLine();
// string fileLower = file.ToLower();

// if (fileLower.EndsWith(".cs"))
//     Console.WriteLine("Файл C#");
// else if (fileLower.EndsWith(".png") || fileLower.EndsWith(".jpg"))
//     Console.WriteLine("Изображение");
// else
//     Console.WriteLine("Неизвестный тип");

// if (file.StartsWith("Lab"))
//     Console.WriteLine("Это лабораторная работа");

// if (fileLower.Contains("test"))
//     Console.WriteLine("Тестовый файл");

// Задание 3

// Console.Write("Введите фразу: ");
// string stroka = Console.ReadLine();
// Console.WriteLine(stroka.ToUpper());
// Console.WriteLine(stroka.Replace(" ", "_"));
// if (stroka.ToLower().Contains("стоп"))
//     Console.WriteLine("Стоп-слово найдено!");

// Задание 4
// Console.Write("Введите дату (2026-09-29): ");
// string date = Console.ReadLine();
// string year = date.Substring(0, 4);
// string month = date.Substring(5, 2);
// string day = date.Substring(8, 2);
// Console.WriteLine($"{day}.{month}.{year}");

// Console.Write("Введите телефон (11 цифр): ");
// string phone = Console.ReadLine();
// string code = phone.Substring(1, 3);
// string part1 = phone.Substring(4, 3);
// string part2 = phone.Substring(7, 2);
// string part3 = phone.Substring(9, 2);
// Console.WriteLine($"+7 ({code}) {part1}-{part2}-{part3}");

// Задание 5 
// Console.Write("Введите строку: ");
// string text = Console.ReadLine();
// int probel = 0;
// int glasn = 0;
// string stroka = "аеёиоуыэюя";
// foreach (char c in text.ToLower())
// {
//     if (c == ' ') probel++;
//     if (stroka.Contains(c)) glasn++;
// }
// Console.WriteLine($"Символов: {text.Length}");
// Console.WriteLine($"Пробелов: {probel}");
// Console.WriteLine($"Гласных: {glasn}");

// Задание 6
