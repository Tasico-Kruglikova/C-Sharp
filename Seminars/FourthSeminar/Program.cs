//На вход число а, выдает сумму чисел от 1 до а
/*
int FindSum (int a)

{
    int summ = 0;

    for (int current = 1; current <= a; current++)
    {
        summ = summ + current;
    }
    return summ;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Summa of numbers from 1 to {num} is {FindSum(num)}");
*/






/*
// На вход число. На выход количество цифер в числе.

int Quantity(int num)
{
    int current = 0;
    for(current = 0; num > 0; current++)
    {
        num = num / 10;
    }
    return  current;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Quantity of digits in the number {num} is {Quantity(num)}");
*/




/*
// Второй метод. На вход число. На выход количество цифер в числе.

int Quantity(int num)
{
    int current = 0;
    while (num > 0)
    {
        num = num / 10;
        current++;
    }
    return  current;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Quantity of digits in the number {num} is {Quantity(num)}");
*/








/*
//Принимает число N и выдает произведение чисел от 1 до N

int FindProduct (int a)

{
    int multiplic = 1;

    for (int current = 1; current <= a; current++)
    {
        multiplic *= current;
    }
    return multiplic;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiplication of numbers from 1 to {num} is {FindProduct(num)}");
*/






/*
//Принимает на вход два числа и А и В , возводит число А в натуральную степень В

int Degree(int a, int b)
{
    int dig = 1;
    for (int current = 0; current < b; current++)
    {
        dig = dig * a;        
    }
    return dig;
}

Console.Write("Input positive integer number A: ");
int numA= Convert.ToInt32(Console.ReadLine());

Console.Write("Input positive integer number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Degree number B from number A is {Degree(numA, numB)}");
*/






