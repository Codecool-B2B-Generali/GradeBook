using GradeBook.ConsoleUI.Model;
using System.IO;

namespace GradeBook.ConsoleUI
{
    internal class DiscBook : Book
    {
        public DiscBook(string name): base(name)
        {

        }
        public override void AddGrade(double grade)
        {
            using(var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
            };           
        }
        public override Statistic GetStatistic()
        {
            return new Statistic();
        }
    }
}