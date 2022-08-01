// 1 TASK. Принимает 3-хзначное число и на выводит 2-ую цифру этого числа
/*
int ShowSecondNumber()
{    
    Console.Write("Input three-digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    do
    {
        Console.Write("Input three-digit number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    while ((number < 100) | (number > 999));

    int two = number / 10;
    int result = two % 10;
    return result;
    
}
int num = ShowSecondNumber();
Console.WriteLine("Second digit is: " + num);
*/


/*
//2 TASK. Выводит третью цифру заданного числа или сообщает что ее нет

void ThirdDigit()
{
    int num = new Random().Next();
    Console.WriteLine("Случайное число " + num);
    int current = num;
    int digit = 0;

    if (num < 100)
    {
        Console.WriteLine("Третьей цифры в числе нет.");
    }
    else
    {
        while (current > 999)
        {
            current = current / 10;
            
        }
        digit = current % 10;
        
    Console.WriteLine("Третья цифра заданного числа " + digit);
    }
}
ThirdDigit();
*/


//3 TASK. Принимает на вход цифру дня недели и сообщает выходной ли это.

void Week()
{
    Console.WriteLine("Введите номер дня недели - ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 0 && num < 8)
    {
        if (num == 6 || num == 7)
        {
            Console.WriteLine("Выходной.");
        }
        else 
        {
            Console.WriteLine("Будний день.");
        }
    }
    else
    {
        Console.WriteLine("Повторите ввод номера дня недели от 1 до 7 ");
    }
}
Week();