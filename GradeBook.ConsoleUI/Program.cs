using System;
using System.Collections.Generic;
using GradeBook.ConsoleUI.Model;

namespace GradeBook.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiscBook("BookList");
            EnterGrade(book);
            var result = book.GetStatistic();

            Console.WriteLine($"The average grade is {result.Average}");
            Console.WriteLine($"The highest grade is {result.Hight}");
            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The letter grade is {result.Letter}");
        }

        private static void EnterGrade(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("....");
                }
            }
        }
    }
}
