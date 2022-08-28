int[] ReverseArray (int[] array)
{
    //for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    //{
    //    int temp = array[i];
    //    array[i] = array[j];
    //    array[j] = temp;
    //}
    //return array;

    int i = 0, j = array.Length - 1;

    while(i < j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;

    }
    return array;
} 

/*
//программа, к. переворачивает одномерный массив 
//(последний элемент б/ на 1-ом месте, а 1-ый -на последнем и т.д.)
int[] myArray = {3, 5, 1 , 8, 2, 9, 4};
myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
*/


/*
//Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.

// 18 / 2 -> 9 0
//  9 / 2 -> 4 1
//  4 / 2 -> 2 0
//  2 / 2 -> 1 0
//  1 / 2 -> 0 1
// 18 -> 10010


string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;

    while(num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2;   //  то же что и num = num / 2;
    }
    return resultNumber;
}
Console.WriteLine (ChangeDigitSystem(18));
*/


/*
//Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.(a < b + c)
bool Triangle(int a, int b, int c)
// {    
//    if (a + b > c && a + c > b && b + c > a) return true;
//    else return false;
// }
{
    return a + b > c && a + c > b && b + c > a;
}
bool answer = Triangle(1, 2 ,5);
Console.WriteLine(answer);
*/



// Например: bool
// int a = 5, b = 3;
// bool c = a > b;  //в переменную bool запишется true


// Например: double
// double a  = Convert.ToDouble(Console.ReadLine());
// double [] array = new double[size];

// double num = new Random().NextDouble(); //генерирует вещественные
//                                            числа от 0.0 до 1.0
// 5.4 = 5.0 + 0.4 (сгенерировано через int и double)


/*
//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
// 0 1 1 2 3 5 8 13 21 34 55
// (каждое последующее число равно сумме двух предыдущих)

int [] Fibonacci(int n)
{
    int[] newArray= new int[n];
    newArray[0] = 0;
    newArray[1] = 1;
    for(int i = 2; i < n; i++)
    {
        newArray[i] = newArray[i-1] + newArray[i - 2];
        Console.Write(newArray[i] + " ");
    }
    return newArray;

}

int[] Show;
Show = Fibonacci(20);
*/