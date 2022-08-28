int SummaPositiveElements (int [] array)
{
    int summa = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) summa ++;
    }
    return summa;
}
/*

//Task 1
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите количество чисел массива: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int [] Array = new int [num];
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент № {i + 1}: ");
    Array[i] = Convert.ToInt32(Console.ReadLine()); 
}

for (int i = 0; i < Array.Length; i++) //вывод массива
    Console.Write(Array[i] + "  ");
Console.WriteLine();

int sum = SummaPositiveElements(Array);
Console.WriteLine("Количество положительных элементов массива:" + sum);
*/



//Task2
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.



double [] Point (double b1, double k1, double b2, double k2)
{
    double [] Array = new double [2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Array[0] = x;
    Array[1] = y;
    return Array;
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double [] ShowPoint = Point(b1, k1, b2, k2);
for (int i = 0; i < ShowPoint.Length; i++)
Console.Write
(ShowPoint[i] + ";"); 