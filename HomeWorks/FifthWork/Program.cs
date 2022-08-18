 int []WrittenMassive (int size, int min, int max)
 {
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max);
    return newArray;
 }

void PrintArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine();
    }

int EvenNumber(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count += 1;
        }
    return count;
}

int Sum (int[]array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1) summa += array[i];
    return summa;
}

double []DoubleArray (int size)
 {
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
        newArray[i] = (new Random().Next(0, 100)) + (new Random().NextDouble());
    return newArray;
 }

void PrintDoubleArray (double[] array)

    {
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i] + " ");
        Console.WriteLine();
    }

Double DifferenceMaxMin (double[]array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];
        Console.WriteLine("min =  " + min);
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
        Console.WriteLine("max =  " + max);
   
    double difference = max - min;
    return difference; 
}



/*
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Input lenght of array: ");
int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max element: ");
// int max = Convert.ToInt32(Console.ReadLine());

int[] array = WrittenMassive(size, 100, 999);
PrintArray (array);
int num = EvenNumber(array);
Console.WriteLine("The number of even element is: " + num);
*/


/*
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Input lenght of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = WrittenMassive(size, min, max);
PrintArray (array);

int sumElements = Sum(array);
Console.WriteLine("The sum of odd element is: " + sumElements);
*/




/*
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Input lenght of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = DoubleArray(size);
PrintDoubleArray (array);

double diff = DifferenceMaxMin(array);
Console.WriteLine("The difference between max and min is " + diff);
*/