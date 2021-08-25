using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.ConsoleUI.Model
{
    public class InMemoryBook : Book
    {
        public InMemoryBook(string name):base(name)
        {
            grades = new List<double>();
            this.Name = name;
        }

        public override Statistic GetStatistic()
        {
            var result =  new Statistic();
            result.Low= double.MaxValue;
            result.Hight = double.MinValue;

            //foreach (var grade in grades)
            for(var index=0; index<grades.Count; index++)
            {
                if(grades[index]== 42.1)
                {
                    continue;
                }
                result.Low = Math.Min(grades[index], result.Low);
                result.Hight = Math.Max(grades[index], result.Hight);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;
            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = "Jeles";
                    break;
                case var d when d >= 80.0:
                    result.Letter = "Jó";
                    break;
                case var d when d >= 70.0:
                    result.Letter = "Közepes";
                    break;
                case var d when d >= 60.0:
                    result.Letter = "Elégséges";
                    break;
                default:
                    result.Letter = "Elégtelen";
                    break;
            }

            return result;          
        }
        public void AddGrade(string letter)
        {
            switch (letter)
            {
                case "Jeles":
                    AddGrade(90);
                    break;
                case "Jó":
                    AddGrade(80);
                    break;
                case "Közepes":
                    AddGrade(70);
                    break;
                case "Elégséges":
                    AddGrade(90);
                    break;

                default:
                    AddGrade(0);
                    break;
            }

        }
        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"invalid {nameof(grade)}");
            } 
        }
        public List<double> grades;
    }
}
