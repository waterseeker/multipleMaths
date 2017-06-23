using System;
public class Exercise10
{
  public static void Main()
  {
    int number1, number2, number3;
 
    Console.Write("Enter first number - "); //promts for user input
    number1 = Convert.ToInt32(Console.ReadLine()); //converts user input to in and assigns to a var
     
    Console.Write("Enter second number - ");
    number2 = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Enter third number - ");
    number3 = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
        number1, number2, number3, ((number1+number2)*number3), (number1*number2+number2*number3));
        //formats user output message and writes to console. 
  }
}