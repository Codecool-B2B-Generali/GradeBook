using GradeBook.ConsoleUI.Model;
using NUnit.Framework;

namespace GradeBook.Tests
{
    public class Tests
    {
        [Test]
        public void BookCalculatesAnAverageGrades()
        {
            // arrage
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistic();
            // assert
            Assert.AreEqual(85.633333333333326d, result.Average);
            Assert.AreEqual(90.5, result.Hight);
            Assert.AreEqual(77.3, result.Low);
            Assert.AreEqual("Jó", result.Letter);
        }
    }
}