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
// Console.Write("Введите слово: ");
// string word2 = Console.ReadLine();
// string reversed = "";
// for (int i = word2.Length - 1; i >= 0; i--)
// {
//     reversed += word2[i];
// }
// Console.WriteLine($"Перевёртыш: {reversed}");
// string word2Lower = word2.ToLower();
// string reversedLower = reversed.ToLower();
// if (word2Lower == reversedLower)
//     Console.WriteLine("Это палиндром");
//  else
//     Console.WriteLine("Это не палиндром");

// Итоговая задача
// Console.Write("Введите email: ");
// string email = Console.ReadLine();

// int Count = 0;
// foreach (char c in email)
// {
//     if (c == '@') Count++;
// }

// string emailLower = email.ToLower();

// if (email.Length < 5)
//     Console.WriteLine("Адрес некорректен: длина меньше 5 символов");
// else if (Count != 1)
//     Console.WriteLine("Адрес некорректен: должно быть ровно один символ @");
// else if (email.StartsWith("@") || email.EndsWith("@"))
//     Console.WriteLine("Адрес некорректен: не должен начинаться или заканчиваться на @");
// else if (email.Contains(" "))
//     Console.WriteLine("Адрес некорректен: содержит пробелы");
// else if (!emailLower.EndsWith(".ru") && !emailLower.EndsWith(".com"))
//     Console.WriteLine("Адрес некорректен: должен заканчиваться на .ru или .com");
// else
//     Console.WriteLine($"Адрес корректен: {emailLower}");

// Доп задание
// using System.Text;
// Console.Write("Введите строку: ");
// string input = Console.ReadLine();
// StringBuilder sb = new StringBuilder();
// string glasn = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
// foreach (char c in input)
// {
//     if (!glasn.Contains(c))
//         sb.Append(c);
// }
// Console.WriteLine($"Без гласных: {sb.ToString()}");