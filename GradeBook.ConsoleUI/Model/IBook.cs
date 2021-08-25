using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.ConsoleUI.Model
{
    public interface IBook
    {
        void AddGrade(double grade);
        Statistic GetStatistic();
        string Name { get; }
    }
}
