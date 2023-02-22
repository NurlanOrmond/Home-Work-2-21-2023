/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int Input (string text)
{
    System.Console.WriteLine(text);
    string income = Console.ReadLine();
    int number = Convert.ToInt32(income);
    return number;
}

int Calculations (int num)
{
    int sum =0;
    for (int i = 0; num > 0; i++)
    {
        sum += num%10;
        num/=10;
    }
    return sum;
}

bool Agreement ( int num)
{
    if (num < 0)
    {
        System.Console.WriteLine("Let's use positive numbers only");
        return false;
    
    }
    else if (num < 10)
    {
        System.Console.WriteLine("No sense to sum one digit number, give me two or more digits.");
        return false;
    }
    else
    {
        return true;
    }
}

int a = Input("Input your number: ");
if (Agreement(a))
{
System.Console.WriteLine($"The sum of all digits in your {a} number is: {Calculations(a)}");
}


