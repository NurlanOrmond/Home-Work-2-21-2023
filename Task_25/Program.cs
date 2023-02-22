int Input (String msg)
{
    Console.Write (msg);
    int val = Convert.ToInt32(Console.ReadLine());
    
    return val;
}


int Compute (int a, int b)
{
    int [] arr = new int [b];
    int res = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a;
        res=res*arr[i];
    }
    return res;
 

} 

bool IsValidate (int n)
{
    if (n < 0)
    {
        Console.WriteLine("Only positive numbers allowed");
        return false;
    }
    return true;

}

int num = Input ("Input Base number ");
int power = Input ("Input Power ");

if (IsValidate (power))
{
    Console.WriteLine(Compute (num, power));
}
