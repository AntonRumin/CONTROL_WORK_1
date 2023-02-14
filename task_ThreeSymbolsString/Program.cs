/* Контрольная работа.
Задание: написать программу
- из имеющегося массива строк сформировать другой массив строк, длина которых не превышает 3-х символов;
- первоначальный массив вводить с клавиатуры или задать на старте программы;
*/

Console.Clear ();

Console.WriteLine ( - - - Выбор элементов с заданным числом символов - - -);

Console.SetCursorPosition(10,2);

Console.ReadLine ("Введите вариант ввода данных (11 - ввод с клавиатуры, 22 - тестовая строка);
string set = Console.ReadLine() ?? "";

// Ввод разделителя

//string set = Console.ReadLine () ?? "";
// Разбиение данных по разделителю (,) и размещение в элементы массива

string[] initialArray = set.Split(null);

// Вывод данных массива с новым разделителем

Console.Write ("Новый набор с разделителем (;) : ");
int lengthInitial = 0;
foreach (var arr in initialArray)
{
    
    Console.Write($"{arr};");
    lengthInitial +=1;
}
Console.WriteLine (lengthInitial);
string [] baseArray = new string [lengthInitial];
string [] reserveArray = new string [lengthInitial];
int x = 3; // введите число проверяемых символов
int k = 0;
int l = 0;

for (int i = 0; i < lengthInitial; i++)
{
    int sl = initialArray[i].Length;
if (sl <= x) 
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

foreach (var element in baseArray)
{
    
    Console.Write($"{element}/");
    
}
Console.WriteLine (k);

foreach (var element in reserveArray)
{
    
    Console.Write($"{element}+");
}
Console.WriteLine (l);
