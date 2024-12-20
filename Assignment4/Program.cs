namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1- Write a program that allows the user to insert an integer then print all numbers 
             * between 1 to that number.
                 Example 
                 Input: 5
                 Output: 1, 2, 3, 4, 5
            */
            Console.Write("Enter an number: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                Console.Write("Output: ");
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(i);
                    if (i < number) Console.Write(", ");
                }
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

            /*2- Write a program that allows the user to insert an integer then 
                 print a multiplication table up to 12.
                     Example
                     Input: 5
                     Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            */

            Console.Write("Enter an number: ");
            int number2;
            if (int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine($"Multiplication table for {number2}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(number2 * i);
                    if (i < 12) Console.Write(" ");
                }
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }

            /*3- Write a program that allows to user to insert number then print all even 
             * numbers between 1 to this number
                 Example:
                 Input: 15
                 Output: 2 4 6 8 10 12 14
             */

            Console.Write("Enter an integer: ");
            int number3;
            if (int.TryParse(Console.ReadLine(), out number3) && number3 > 0)
            {
                Console.WriteLine("Even numbers between 1 and {0}:", number3);
                for (int i = 2; i <= number3; i += 2)
                {
                    Console.Write(i);
                    if (i + 2 <= number3) Console.Write(" "); 
                }
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

            /*4- Write a program that takes two integers then prints the power.
                    Example:
                    Input: 4 3
                    Output: 64
                    Hint: how to calculate 4^3 = 4 * 4 * 4 =64
             */

            Console.Write("Enter the NumberOne: ");
            int NumberOne;

            Console.Write("Enter the NumberTwo: ");
            int NumberTwo;
            if (int.TryParse(Console.ReadLine(), out NumberOne) && int.TryParse(Console.ReadLine(), out NumberTwo))
            {
                int result = 1;

                for (int i = 0; i < NumberTwo; i++)
                {
                    result *= NumberOne;
                }
                Console.WriteLine($"{NumberOne}^{NumberTwo} = {result}");
            }
            else
            {
                Console.WriteLine("Please enter valid integers.");
            }

            /*5- Write a program to enter marks of five subjects and calculate total, average
             * and percentage.
                Example
                Input: - Enter Marks of five subjects: 95 76 58 90 89
                Output: Total marks = 408
                Average Marks = 81
                Percentage = 81
            */

            int[] marks = new int[5];
            int totalMarks = 0;

            Console.WriteLine("Enter marks of five subjects:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out marks[i]) && marks[i] >= 0 && marks[i] <= 100)
                {
                    totalMarks += marks[i];
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter marks between 0 and 100.");
                    i--; 
                }
            }

            double averageMarks = (double)totalMarks / marks.Length;
            double percentage = (totalMarks / 500.0) * 100;

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Total Marks = {totalMarks}");
            Console.WriteLine($"Average Marks = {averageMarks:F2}");
            Console.WriteLine($"Percentage = {percentage:F2}%");

            /*6- Write a program to input the month number and print the number of days in 
             * that month.
                    Example
                    Input: Month Number: 1
                    Output: Days in Month: 31
            */

            Console.Write("Enter Month Number (1-12): ");
            int monthNumber;

            if (int.TryParse(Console.ReadLine(), out monthNumber) && monthNumber >= 1 && monthNumber <= 12)
            {
                int days;

                switch (monthNumber)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        days = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        days = 30;
                        break;
                    case 2:
                        Console.Write("Is it a leap year? (yes/no): ");
                        string isLeapYear = Console.ReadLine()?.ToLower();
                        days = (isLeapYear == "yes") ? 29 : 28;
                        break;
                    default:
                        days = 0; 
                        break;
                }

                Console.WriteLine($"Days in Month: {days}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
            }

            /*7- Write a program to create a Simple Calculator.*/

            /*8- Write a program to allow the user to enter int and print the REVERSED 
             * of it.*/

            Console.Write("Enter an integer: ");
            int number8;

            if (int.TryParse(Console.ReadLine(), out number8))
            {
 
                int reversedNumber = 0;
                while (number != 0)
                {
                    int digit = number8 % 10;
                    reversedNumber = reversedNumber * 10 + digit;
                    number8 /= 10;
                }

                Console.WriteLine($"Reversed Number: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            /*9- Write a program in C# Sharp to find prime numbers within a range of numbers.
                 Test Data :
                 Input starting number of range: 1
                 Input ending number of range : 50
                 Expected Output :
                 The prime number between 1 and 50 are :
                 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            */


            /*10- . Write a program in C# Sharp to convert a decimal number into binary without 
             * using an array.
                     Test Data :
                     Enter a number to convert : 25
                     Expected Output :
                     The Binary of 25 is 11001.
            */
            Console.Write("Enter a number to convert: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryRepresentation = ConvertToBinary(decimalNumber);

            Console.WriteLine($"The Binary of {decimalNumber} is {binaryRepresentation}");
        }
        static string ConvertToBinary(int number)
        {
            if (number == 0)
                return "0"; 

            string binary = "";

            while (number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2;
            }

            return binary;
        }
    }
}
