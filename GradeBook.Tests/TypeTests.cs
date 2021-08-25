using GradeBook.ConsoleUI.Model;
using NUnit.Framework;
using System;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            Assert.AreEqual("Book 1", book1.Name);
            Assert.AreEqual("Book 2", book2.Name);      
        }

        [Test]
        public void TwoVarsCanBeReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.AreEqual(book1, book2);
            Assert.True(object.ReferenceEquals(book1,book2));
        }

        [Test]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "new name");
            Assert.AreEqual("new name", book1.Name);

        }
        [Test]
        public void CharpIsPassbyValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "new name");
            Assert.AreEqual("Book 1", book1.Name);

        }

       
        [Test]
        public void ValueTypesAlsoPassByVRef()
        {
            var x = GetInt();
            SetInt(x);
            Assert.AreEqual(42, x);
        }
        private int GetInt()
        {
            return 3;
        }
        private void SetInt(int x)
        {
            x = 42;
        }
    
       

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
            book.Name = name; 
        }
        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }
        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }

    }
}