// Метод который генерирует массив из целочисленных элементов,
//которые заданы случайным образом.
int[]CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

//Метод, который создает массив, элементы которого задает пользователь
int [] CreateArray(int size)
{
    int [] newArray = new int[size];

    Console.WriteLine("Creating array here:");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    return newArray;
}

//Выводит (печатает) массив на экран, ничего не возвращает.
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindPositiveSumm(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++ )
        if (array[i] > 0) summa += array[i];
    return summa;
}

int[] Change (int [] array3)  //такая запись когда в качестве результата хотят вернуть массив
{
    
    for (int i= 0; i < array3.Length; i++)
        array3[i] = array3[i] * (-1); 
    return array3;
    
}

int Quantity (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]>= 10 && array[i]<100) count++;
    
    return count;

}


/*
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму положительных элементов массива.
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input min posible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input max posible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int sumOfPositive = FindPositiveSumm(array);
Console.WriteLine("Sum of positive elements in current array is " + sumOfPositive);
//Console.WriteLine("Sum of positive elements in current array is " + FindPositiveSumm(array));
*/





/*
//Написать программу, которая заменит полож-ые элементы массива на отриц-ные(н:9 -> (-9))
//и наоборот отриц-ые на полож-ые.
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input min posible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input max posible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int[]Changed = Change(array);
ShowArray(Changed);
*/



/*
//Задать одномерный массив, из 20 случайных чисел.
//Найти количество элементов массива, значения которых лежать между 10 и 99 включительно 
int size = 20;
Console.Write ("Input min posible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input max posible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("The number of elements from 10 to 99 in the massive is: " + Quantity(array));
*/