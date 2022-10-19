/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

/*
Console.WriteLine("Введите 1 сторону треугольник= ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 сторону треугольник= ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 3 сторону треугольник= ");
int C = int.Parse(Console.ReadLine()!);

if (A < B + C && B < A + C && C < A + B){
    Console.WriteLine("Треугольник с сторонами такой длины может существовать");
}
else{
   Console.WriteLine("Треугольник с сторонами такой длины не может существовать"); 
}
*/

/*
**Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

/*
int num = ReadLine("введите число:");
string res = Convert.ToString(num, 2);
Console.WriteLine($"Ваше число в двоичной ситеме исчисления -->> {res}");

int ReadLine(string masseg)
{
    Console.WriteLine(masseg);
    int Read = Convert.ToInt32(Console.ReadLine()!);
    return Read;
}
*/
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

/*
int[] array = GetArray(5, 1, 100);
Console.WriteLine($"[{String.Join(" ", array)}]");

int[] result = ReversArray(array);
Console.WriteLine($"[{String.Join(" ", result)}]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[] ReversArray(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[i];
    }
    return result;
}
*/

/*
int[] array = { 6, 84, 544, 87, 4};
int[] copyz = new int[array.Length];
array.CopyTo(copyz, 0);
Console.WriteLine(String.Join(". ", array));
Console.WriteLine(String.Join(", ", copyz));
*/




// HomeWork
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
Console.WriteLine ("Введите элементы через пробел");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int sum = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i]>0){
        sum++;
    }
}
Console.WriteLine($"Количество элементов больше 0: {sum}");
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine()!);

// обе части равны y, поэтому k1*x+b1=k2*x+b2, следовательно:
var x = (b2-b1)/(k1-k2);
var y = k1*x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Координаты пересечения двух прямых: ");
Console.WriteLine($"x = {x}; y = {y}");
*/