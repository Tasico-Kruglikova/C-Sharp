/*
//На вход число, на выход сумма цифр в этом числе.
int Summa(int num)
{
    int sum = 0;
    for (int current = 1; num > 0; current *= 10)
    {
        current = num % 10;
        num = num / 10;
        sum = sum + current;
    }
    return sum;
}


Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Summa of digits in the number is: "+Summa(number));
*/





int[]CreateMassive(int m, int min, int max)
{
    int [] Array = new int[m]; 
    for (int i = 0; i < m; i++)
        Array[i] = new Random(). Next(min, max+1);
    return Array;
}

void PrintArray (int []Array)
{
    for (int i = 0; i < Array.Length; i++)
        Console.Write(Array[i] + " ");
}

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
Console.Write("Input a number equal to the elements in the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateMassive(size, min, max);
PrintArray(newArray);
