using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp0310
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Qn. 1 Multiplication table of a given number
            //Console.WriteLine("Enter a number"); //gets number
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    int product = i * number; //finds product
            //    Console.WriteLine($"{i}*{number}={product}"); //outputs table
            //}
            //Console.ReadLine();

            //Qn. 2 Display a right-angled triangle
            //Console.WriteLine("Enter number of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Qn. 3 Sum of all even numbers between 1 and 100 
            //int i = 0;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if ((i % 2) == 0)
            //    {
            //        sum = sum + i;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Sum of even nos. till 100 is: {sum}");
            //Console.ReadLine();

            //Qn. 4 Multiplication table from 1 to 5
            //for (int j = 1; j <= 5; j++)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        int product = i * j;
            //        Console.WriteLine($"{i}*{j}={product}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Qn. 5  Print Positive Number 
            //label:  Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt32(Console.ReadLine()); //reads number
            //if(number>0)
            //{
            //    Console.WriteLine("Entered number is: " + number); //outputs if positive
            //    goto label;
            //}
            //else if (number==0)
            //{
            //    Console.WriteLine("You entered zero"); //outputs if zero
            //    goto label;
            //}
            //else
            //{
            //    Console.WriteLine("You entered a negative number"); //outputs if negative
            //    return;
            //}

            //Qn. 6 Create Menu Driven Calculator
            /* Label: Console.WriteLine("Do you wish to use the calculator?");
                 string userWish = Console.ReadLine();
                 if (userWish.ToLower() == "yes")
                 {

                     Console.WriteLine("Enter two numbers");
                     int number1 = Convert.ToInt32(Console.ReadLine());
                     int number2 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter operator");
                     string myOperator = Console.ReadLine();
                     if (myOperator == "+")
                     {
                         int sum = number1 + number2;
                         Console.WriteLine("Sum is: " + sum);
                         goto Label;
                     }
                     else if (myOperator == "-")
                     {
                         int difference = number1 - number2;
                         Console.WriteLine("Difference is: " + difference);
                         goto Label;
                     }
                     else if (myOperator == "*")
                     {
                         int product = number1 * number2;
                         Console.WriteLine("Product is: " + product);
                         goto Label;
                     }
                     else if (myOperator=="/")
                     {
                         if (number2 == 0)
                         {
                             Console.Write("Division by zero is not possible");
                         }
                         else
                         {
                             int quotient = number1 / number2;
                             Console.WriteLine("Quotient is: " + quotient);
                             goto Label;
                         }
                     }
                 } 
                 else if (userWish.ToLower() == "no")
                 {
                     return;
                 } */

            //Qn. 7 Print All Numbers From 1 to 100
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    if (i > 50)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Qn. 8 Sum of Odd Numbers 
            //int sum = 0;
            //for (int i = 1; i < 100; i += 2)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine($"Sum of all odd numbers between 1 and 100 is {sum}.");
            //Console.ReadLine();

            //Qn. 9 Factorial Calculation 
            //Console.WriteLine("Enter a number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int factorial = 1;
            //while(i<number+1)
            //{
            //   factorial = factorial * i;
            //    i++;
            //}
            //Console.WriteLine("Factorial is: "+factorial);
            //Console.ReadLine();

            //Qn. 10 Number Pyramid
            //Console.WriteLine("Enter no. of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(i + 1);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Qn. 11 Guess the Number Game
            /* Label:  Console.WriteLine("Do you wanna play?");
             string userInput = Console.ReadLine();
             if (userInput.ToLower() == "yes")
             {
                 int no_of_rounds = 4;
                 do
                 {
                     Console.WriteLine("Enter a number between 1 and 100");
                     int number = Convert.ToInt32(Console.ReadLine());
                     Random rnd = new Random();
                     int num = rnd.Next(1, 100);
                     if ((number - num) > 0)
                     {
                         Console.WriteLine("High");
                         no_of_rounds--;
                     }
                     else if ((number - num) < 0)
                     {
                         Console.WriteLine("Low");
                         no_of_rounds--;
                     }
                     else if ((number - num) == 0)
                     {
                         Console.WriteLine("Hurray, you got it right");
                         no_of_rounds--;
                     }

                 }while (no_of_rounds > 0);
                 goto Label;
             }
             else
             {
                 return;
             }
             */
            //Qn. 12 Simple Calculator
            /*Label: Console.WriteLine("Do you wish to use the calculator?");
                string userWish = Console.ReadLine();
                if (userWish.ToLower() == "yes")
                {
                    Console.WriteLine("Enter two numbers");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication and 4 for division");
                    int myOperator = Convert.ToInt32(Console.ReadLine());
                    switch(myOperator)
                    {
                        case 1: 
                        int sum = number1 + number2;
                        Console.WriteLine("Sum is: " + sum);
                        goto Label;

                        case 2:
                        int difference = number1 - number2;
                        Console.WriteLine("Difference is: " + difference);
                        goto Label;

                        case 3:
                        int product = number1 * number2;
                        Console.WriteLine("Product is: " + product);
                        goto Label;

                        case 4: 
                        if (number2 == 0)
                        { 
                            Console.Write("Division by zero is not possible");
                        }
                        else
                        {
                            int quotient = number1 / number2;
                            Console.WriteLine("Quotient is: " + quotient);
                            goto Label;
                        }
                        break;
                    }
                }
                else if (userWish.ToLower() == "no")
                {
                    return;
                } */

            //Qn. 13 Sum of Digits 
            //Console.WriteLine("Input a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //do
            //{
            //    int remainder = number % 10;
            //    number = number / 10;
            //    sum += remainder;
            //} while (number > 0);
            //Console.WriteLine("Sum is: " + sum);
            //Console.ReadLine();

            //Qn. 14 Finding the Largest Number
            //int[] arr = new int [10];
            //Console.WriteLine("Enter 10 numbers: ");
            //for (int i = 0;i<10;i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int largest = 0;
            //for (int j = 0;j<10;j++)
            //{
            //    if (arr[j] > largest)
            //    {
            //        largest = arr[j];
            //    }
            //}
            //Console.WriteLine("Largest is: "+largest);
            //Console.ReadLine();

            //Qn. 15 Sum of Squares
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //int sum = 0;
            //while(i<number+1)
            //{
            //    sum = sum + i * i;
            //    i++;
            //}
            //Console.WriteLine("Sum is: " + sum);
            //Console.ReadLine();

            //Qn. 16 Countdown Timer

            //int count = 10;
            //do
            //{
            //    Console.WriteLine(count);
            //    count--;
            //    System.Threading.Thread.Sleep(1000);
            //}while (count > 0);
            //Console.WriteLine("Countdown complete!");
            //Console.ReadLine();


            // Qn. 17  Finding the First Multiple of 5 
            //int[] arr = new int[10];
            //Console.WriteLine("Enter total number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter numbers");
            //for (int i=0;i<n;i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    if (arr[j] % 5 == 0)
            //    {
            //        Console.WriteLine("First multiple of 5 is " + arr[j]);
            //        break;
            //    }
            //}
            //Console.ReadLine();

            //Qn. 18 Print Non-Multiples of 3
            //for (int i = 0; i < 21; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Qn. 19 Checking for Palindrome
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem = num%10;




        }
    }
}
