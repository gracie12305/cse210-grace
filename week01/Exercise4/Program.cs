using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
       int userNumber = -1;

       //we use the while loop
       while (userNumber !=0)
       {
        Console.Write("Enter a list of numbers, enter 0 when finished");
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);

        if (userNumber != 0)
        {
            numbers.Add (userNumber);
        }
     
       }
       
       //comute sum
       int sum =0;
       foreach(int number in numbers)
       {
        sum += number;
       }
        Console.WriteLine($"The sum is :{sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        //Find the max

        int max = (numbers[0]);
        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}");
    }

}
