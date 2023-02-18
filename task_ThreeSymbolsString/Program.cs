/* Контрольная работа.
Задание: написать программу, которая: 
- из имеющегося массива строк формирует другой массив строк, длина которых не превышает 3-х символов;

Первоначальный массив можно вводить с клавиатуры или задать на старте программы;
*/

Console.Clear ();

Console.WriteLine ( "- - - - - -Выбор элементов с заданным числом символов - - - - - -");
Console.SetCursorPosition(2,3);

Console.Write ("Введите вариант ввода данных (11 - ввод с клавиатуры, 22 - тестовая строка): ");

string way = Console.ReadLine () ?? "";  // Устанавливаем способ ввода данных
string set = String.Empty;               // Объявляем переменную для ввода строки с данными
string [] initialArray = new string [1]; // Объявляем первоначальный массив
int symbol = 0;                          // Объявляем переменную с количеством символов для сортировки

Console.SetCursorPosition(3,5);

// Настройка работы программы в зависимости от способы ввода данных

if (way == "11") // Ввод с клавитауры
{
Console.WriteLine ("(!) Ввод первоначального массива строк осуществляется с клавиатуры.");
Console.Write ("Укажите код для типа разделителя: для (,) введите 1; для (/) введите 2; для (;) введите 3; для (' ') введите любое другое число: ");
string separator = Console.ReadLine() ?? "";

Console.Write ("Введите данные, используя выбранный разделитель: ");
set = Console.ReadLine() ?? "";

Console.Write ("Введите число символов для отбора элементов: ");
symbol = int.Parse(Console.ReadLine () ?? "");

Console.WriteLine ($"Отбор будет произведен для элементов, содержащих не более {symbol} символов");
// Учет разделителя при разбиении строки на элементы
switch (separator)  
{
case "1":
initialArray = set.Split(',');
break;

case "2":
initialArray = set.Split('/');
break;

case "3":
initialArray = set.Split(';');
break;

default:
initialArray = set.Split(' ');
break;
}
}
else
{
Console.WriteLine ("(!) Используется тестовая строка.");
Console.WriteLine ("В тестовой строке разделитель - пробел.");   
set = "Одн ажды в студе ную зим нюю пору я из лесу вышел";
initialArray = set.Split(' ');
symbol = 3;
Console. WriteLine ($"Будут отобраны элементы, которые содержат не более {symbol} элеменов");
}
Console.WriteLine();

// Вывод строки в виде отдельных элементов массива (для контроля работы программы).

Console.WriteLine ("В исходном массиве выделены элементы: ");
int lengthInitial = 0;
foreach (var arr in initialArray)
{
    
    Console.Write ($"{arr} ; ");
    lengthInitial +=1;
}

Console.WriteLine();
Console.WriteLine ($"Итого: {lengthInitial} элементов;"); // Вывод количества элементов в первоначальном массиве

// Обявление рабочих массивов для распределения элементов первоначального массива

string [] baseArray = new string [lengthInitial];        // Массив для элементов, прошедших отбор
string [] reserveArray = new string [lengthInitial];     // массив для элементов, не прошедших отбор

// Объявление переменных для управления длиной рабочих массивов
int k = 0;
int l = 0;

// Циклы для распределения элементов первоначального массива по рабочим массивам в зависимости от выполнения условий отбора
for (int i = 0; i < lengthInitial; i++)
{
    int sl = initialArray[i].Length;
    
if (sl <= symbol & initialArray[i] != " ") // Проверка на количество символов и пробел
{
    baseArray[k] = initialArray[i];
    k +=1;
}
else
{
   reserveArray [l] = initialArray [i];
   l +=1;
}
}

// Настройка длины рабочих массивов
Array.Resize (ref baseArray, k);
Array.Resize (ref reserveArray, l);

// Вывод элементов рабочих массивов
Console.WriteLine ();
Console.WriteLine ("Отобраны элементы:"); 

foreach (var element in baseArray)  // Вывод элементов, которые удовлетворяют условиям отбора
{
    
    Console.WriteLine ($"{element}");
    
}
Console.WriteLine();
Console.WriteLine ($"Всего отобрано {k} элементов.");

Console.WriteLine();
Console.Write ("Не прошли отбор следующие элементы: "); 

foreach (var element in reserveArray)// Вывод элементов, которые не удовлетворяют условиям отбора
{
    
    Console.Write ($"{element} ; ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine ($"Итого не прошло отбор {l} элементов.");
