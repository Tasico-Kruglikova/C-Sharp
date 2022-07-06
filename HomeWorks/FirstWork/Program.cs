//TASK1
/*
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
*/





//TASK2
/*
int num1, num2, num3, max;

Console.Write("Введите первое число ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        max = num1;
    }
    else
    {
        max = num3;
    }
}
else
{
    if (num2 > num3)
    {
        max = num2;
    }
    else
    {
        max = num3;
    }
}

Console.WriteLine(max);
*/






//TASK3
/*
int num;

Console.Write("Введите число ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}
*/




//TASK4
/*
int num;

Console.Write("Введите число ");
num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
    }  
    current++;
}
*/