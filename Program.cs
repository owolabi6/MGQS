using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)

        {
    
            //Question 1

            Console.WriteLine("Enter Input :");
            string inOne = Console.ReadLine();
            Console.WriteLine("Enter Input:");
            string inTwo = Console.ReadLine();
    
            Console.WriteLine("The lenght of the first input is:" + inOne.Length);
            Console.WriteLine("The lenght of the second input is:" + inTwo.Length);

            int add = inOne.Length + inTwo.Length;
            Console.WriteLine( add);

            //int avr = 20;
            int mul = 3;
            int oth = 20; 
           if (add > 20)
           {
               Console.WriteLine( add * mul);
           }
           else
           { 
               Console.WriteLine(add + oth);
           }

           

          //Question 2

         //double costPrice = 200.876, sellingPrice = 255.425, prmat;
         decimal costPrice;
         costPrice = 200.876m;
         decimal sellingPrice;
         sellingPrice = 255.425m;
         
         decimal profit = (sellingPrice - costPrice);
         Console.WriteLine($"The Profit made is $ {sellingPrice - costPrice}");
         Console.WriteLine($"The Profit made is $ {Math.Round(profit,2)}");
        


         // Question 3 
         Console.WriteLine("Enter any word");
         string name = Console.ReadLine();
         int index = (int)name[3];
         int wordLength = name.Length;
         int sum = name.IndexOf(name[3]) + name.Length;
         char result = (char)sum;   

         Console.WriteLine($"The index of third charater is {name.IndexOf(name[3])}");
         Console.WriteLine($"The length of the string is {name.Length}");
         Console.WriteLine($"The character of the answer is {(char)sum}");
       

          // Question 4

         /* Console.WriteLine("Input the first number : ");
          double firstNumber = double.Parse(Console.ReadLine());

          Console.WriteLine("Input the second number : ");
          double secondNumber = double.Parse(Console.ReadLine());

          double compareNumbers =Math.Max(firstNumber,secondNumber);
          Console.WriteLine("Number {0} is greater" ,compareNumbers);

         //  Question 5

           int sum = 0;
           int i =0;
           while (i <=4)
    
         { 
           Console.WriteLine("Please enter number :");
           string input = Console.ReadLine();

           int x;
           bool isInteger = int.TryParse(input, out x);
           if(!isInteger)
           {
               i--;
               Console.WriteLine("Invalid Input! ");

           }
            sum+= x;
            i++;
         }
           Console.WriteLine($"The sum of th number is {sum}");


         
	     //5.Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)
        
            
           /* int sum = 0;
            for (var i = 1; i <= numbers; i++)
            {
                Console.WriteLine("Please enter number " + i + ":");
                string input = Console.ReadLine();

                int integerInput;
                bool isInteger = int.TryParse(input, out integerInput);

                if (isInteger == false)
                {
                    Console.WriteLine("Enter another number");
                    continue;
                }
                else
                {
                    sum += integerInput;

                }
            }
            Console.WriteLine("The sum is: " + sum); */

        

           //Question 6

           /*const int value = 5;
           Console.WriteLine("input  first number :");
           double firstNum = int.Parse(Console.ReadLine());
           Console.WriteLine("Input  second number :");
           double secondNum = int.Parse(Console.ReadLine());
           double sUm = firstNum + secondNum -value;
           Console.WriteLine("Input correct Number:");
           double correct = int.Parse(Console.ReadLine());
            
           string resulT = (sum == correct)? "correct Answer!" : $"Wrong Answer! The Correct answer is {sUm}";
           Console.WriteLine(res)*/



          /*  int num1 = 1;
            int num2 = 2;
            int num3 = 5;

            int result = num1 + num2 - num3;
            Console.WriteLine("Enter Correct Answer:");
            int correctAnswer = Convert.ToInt32(Console.ReadLine());
            if(correctAnswer == result)
            Console.WriteLine("Correct answer!");
            else
            Console.WriteLine("Wrong Answer! Correct answer is:"+ result);8/


            // Question 7


            Console.WriteLine("Enter a number between 0 and 9:");
            string statement = Console.ReadLine();

            switch (statement)
            {
                case "0": Console.WriteLine("zero"); break;
                case "1": Console.WriteLine("one"); break;
                case "2": Console.WriteLine("two"); break;
                case "3": Console.WriteLine("three"); break;
                case "4": Console.WriteLine("four"); break;
                case "5": Console.WriteLine("five"); break;
                case "6": Console.WriteLine("six"); break;
                case "7": Console.WriteLine("seven"); break;
                case "8": Console.WriteLine("eight"); break;
                case "9": Console.WriteLine("nine"); break;
                default: Console.WriteLine("not a recognised digit"); break;
            }*/    
        
        }
    }
}        
