using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämmningsuppgift_1_EmilÖrjes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My If Else Calculator";
            Console.WriteLine("You can choose betwen these operators:  +  -  *  /");
            List<double> sumList = new List<double>();
            const string exit = "x";
            string continueOreExit = "";

            while (continueOreExit != exit)
            {
                Console.WriteLine();
                Console.Write("Enter first operator: ");
                string firstOp = Console.ReadLine();
                char firstOperator = Convert.ToChar(firstOp);

                Console.Write("Enter second operator: ");
                string secondOp = Console.ReadLine();
                char secondOperator = Convert.ToChar(secondOp);

                Console.Write("Enter first term: ");
                double firstTerm = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second term: ");
                double secondTerm = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter third term: ");
                double thirdTerm = Convert.ToDouble(Console.ReadLine());




                double sum;

                if (firstOperator == '+')
                {
                    if (secondOperator == '+')
                    {
                        sum = firstTerm + secondTerm + thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} + {secondTerm} + {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.Write("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }


                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }

                    }
                    else if (secondOperator == '-')
                    {
                        sum = firstTerm + secondTerm - thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} + {secondTerm} - {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }

                            else if (sum > 100)
                            {
                                Console.WriteLine("\"The sum is more than a hundred\"");
                                Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                                continueOreExit = Console.ReadLine();
                                if (continueOreExit == exit)
                                {
                                    Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                    Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                                }
                            }
                            else if (sum == 100)
                            {
                                Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                                Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                                continueOreExit = Console.ReadLine();
                                if (continueOreExit == exit)
                                {
                                    Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                    Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                                }
                            }
                        }
                    }
                    else if (secondOperator == '*')
                    {
                        sum = firstTerm + (secondTerm * thirdTerm);
                        Console.WriteLine($"Svar: {firstTerm} + {secondTerm} * {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '/')
                    {
                        sum = firstTerm + (secondTerm / thirdTerm);
                        Console.WriteLine($"Svar: {firstTerm} + {secondTerm} / {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }

                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }

                        }
                    }


                }

                if (firstOperator == '-')
                {
                    if (secondOperator == '+')
                    {
                        sum = firstTerm - secondTerm + thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} - {secondTerm} + {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }

                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }

                        }
                    }
                    else if (secondOperator == '-')
                    {
                        sum = firstTerm - secondTerm - thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} - {secondTerm} - {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '*')
                    {
                        sum = firstTerm - (secondTerm * thirdTerm);
                        Console.WriteLine($"Svar: {firstTerm} - {secondTerm} * {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '/')
                    {
                        sum = firstTerm - (secondTerm / thirdTerm);
                        Console.WriteLine($"Svar: {firstTerm} - {secondTerm} / {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                }
                if (firstOperator == '*')
                {
                    if (secondOperator == '+')
                    {
                        sum = (firstTerm * secondTerm) + thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} * {secondTerm} + {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '-')
                    {
                        sum = (firstTerm * secondTerm) - thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} * {secondTerm} - {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '*')
                    {
                        sum = (firstTerm * secondTerm) * thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} * {secondTerm} * {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '/')
                    {
                        sum = (firstTerm * secondTerm) / thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} * {secondTerm} / {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                }
                if (firstOperator == '/')
                {
                    if (secondOperator == '+')
                    {
                        sum = (firstTerm / secondTerm) + thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} / {secondTerm} + {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '-')
                    {
                        sum = (firstTerm / secondTerm) - thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} / {secondTerm} - {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '*')
                    {
                        sum = (firstTerm / secondTerm) * thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} / {secondTerm} * {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }
                    else if (secondOperator == '/')
                    {
                        sum = (firstTerm / secondTerm) / thirdTerm;
                        Console.WriteLine($"Svar: {firstTerm} / {secondTerm} / {thirdTerm} = {sum}");
                        sumList.Add(sum);
                        if (sum < 100)
                        {
                            Console.WriteLine("\"The sum is less than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum > 100)
                        {
                            Console.WriteLine("\"The sum is more than a hundred\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                        else if (sum == 100)
                        {
                            Console.WriteLine("\"Cool, now you have a hundred, clap clap\"");
                            Console.WriteLine("Another Try? Continue = Enter |  Exit = x: ");
                            continueOreExit = Console.ReadLine();
                            if (continueOreExit == exit)
                            {
                                Console.WriteLine($"Sum of each calculation: {string.Join('+', sumList)}");
                                Console.WriteLine($"Thank you for playing. The sum of all round is {sumList.Sum(x => Convert.ToDouble(x))}. Bye, have a nice day!");
                            }
                        }
                    }

                }
            }
        }
    }
} 
