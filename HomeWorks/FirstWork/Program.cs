int num1, num2, max;

Console.Write("Введите первое число ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
 {
    max = num1;
 }   
else
{
    max = num2;
}
Console.WriteLine("Большее число " + max);