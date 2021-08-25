using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.ConsoleUI.Model
{
    public abstract class Book : NamedObject, IBook
    {
        public Book( string name) : base(name)
        {
            Name = name;
        }
    public abstract void AddGrade(double grade);
    public abstract Statistic GetStatistic();
    }
}
