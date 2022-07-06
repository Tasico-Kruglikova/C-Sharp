/* First Task: является ли первое число квадратом второго.

int num1, num2, quat;

Console.Write("Inpup a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpup a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quat = num2 * num2;

if (quat == num1)
{
    Console.WriteLine("First number is quat of second number.");
}
else
{
    Console.WriteLine("First number is NOT quat of second number.");
}
*/


/*
// Second Task: Написать программу, 
//которая будет выдавать название дня недели по заданному номеру.

int num;


Console.Write("Введите число дня недели с 1 до 7: ");
num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Снова понедельник.");
}
if (num == 2)
{
    Console.WriteLine("Вторник.");
}
if (num == 3)
{
    Console.WriteLine("Среда.");
}
if (num == 4)
{
    Console.WriteLine("Четверг.");
}
if (num == 5)
{
    Console.WriteLine("Ура! Пятница.");
}
if (num == 6)
{
    Console.WriteLine("Суббота.");
}
if (num == 7)
{
    Console.WriteLine("Воскресенье.");
}
if (num > 7 || num <1) 
{
    Console.WriteLine("Вы ввели число большее 7. Попробуем ещё раз.");
    Console.Write("Введите число дня недели с 1 до 7: ");
    num = Convert.ToInt32(Console.ReadLine());
}

*/

/*
// Third Task: Напишите программу, 
//которая на вход принимает число и 
//выдает его квадрат.

int num;
int quat;

Console.Write("Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());

quat = num * num;

Console.Write("Вот и квадрат вашего чила: " + quat);
*/


// Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = n * (-1);

while (current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

