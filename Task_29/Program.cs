  /*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Hello! My program create array containing the random numbers in range of 0...1000. The length of array is your priority*/

int InputMessage (string text)
{
  System.Console.WriteLine(text);
  string inputInfo = Console.ReadLine ();
  int num = Convert.ToInt32(inputInfo);
  return num;

}

int [] ArrayProduser (int length)
{

int [] arr = new int [length];

for (int i=0; i<length; i++)
{
    Random rnd = new Random();
    arr [i] = rnd.Next(1,1001);
}
return arr;
}

void ShowArray (int [] a)
{ 
  
  System.Console.Write("[");   
  for (int i = 0; i < a.Length-1; i++)
  {
    
    System.Console.Write(a[i]+", ");
    

  }
  System.Console.Write(a[a.Length-1]); 
  System.Console.Write("]"); 

}


int size = InputMessage ("Define the size of an array: ");

ArrayProduser (size);

System.Console.WriteLine("The content of your array is: ");

ShowArray (ArrayProduser (size));




