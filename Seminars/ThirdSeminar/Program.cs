// На ввод принимает номер четверти координат. На выход нужно диапазон значений в этой четверти.
/*

void ShowArea (int quart)
{
    if (quart >= 1 && quart <= 4)
    {
        if (quart == 1) Console.WriteLine("It this quart x > 0 and y > 0");
        if (quart == 2) Console.WriteLine("It this quart x < 0 and y > 0");
        if (quart == 3) Console.WriteLine("It this quart x < 0 and y < 0");
        if (quart == 4) Console.WriteLine("It this quart x > 0 and y < 0");
    }
    else
    Console.WriteLine("This number is uncorrect");


Console.WriteLine("Input number of quart");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);
}
*/









//На вход принимает координаты точки x,у. На выход должен показать в какой четверти будет находится точка точка
/*
int WhatQuart (int x, int y)
{
    int result = -1;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    return result;  
}

Console.Write("Inpun x: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpun у: ");
int numY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quart is " + WhatQuart (numX, numY));
*/








//На вход число N, на выход квадраты чисел от 1 до N


void Quad(int n)
{
    int current = 1;
    while (current <= n)
    {
        int quad = current * current;
        Console.Write(quad + " ");
        current++;
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Quad(num);