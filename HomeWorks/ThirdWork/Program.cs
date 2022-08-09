
// Принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

void Palindrome (int n)
{
    int first = n / 10000;
    int second = (n / 1000) % 10;
    int third = (n / 100) % 10;
    int fourth = (n / 10) % 10;
    int fifth = n %10;
    
    if(first == fifth && second == fourth) Console.WriteLine("Its palindrome.");
    else Console.WriteLine("Its not palindrome.");

}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 9999 || number >= 100000)
{
    Console.WriteLine("Its not a five-digit number.");
}
else
{
    Palindrome(number);
}


/*
// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cubes (int n)
{
    int current = 1;
    while (current < n)
    {
        int cube = current * current * current;
        Console.Write("  " + cube);
        current++;
    }
    
}


Console.Write("Input an integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) Console.WriteLine ("The number is not an integer.");
Cubes (num);
*/