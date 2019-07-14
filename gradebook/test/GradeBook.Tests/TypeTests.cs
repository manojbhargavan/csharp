using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypeIsPassByValue()
        {
            //Arrange
            int x = 10;
            GetInt(ref x);            

            //Act

            //Assert
            Assert.Equal(42, x);
        }

        private void GetInt(ref int x)
        {
            x = 42;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            //Arrange
            var book1 = GetBook("Book1");
            GetBookSetName(ref book1, "New Name");

            //Act

            //Assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = GetBook(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            //Arrange
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");

            //Act

            //Assert
            Assert.Equal("Book1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = GetBook(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //Arrange
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");

            //Act

            //Assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            //Arrange
            var book1 = GetBook("Book1");
            var book2 = book1;

            //Act

            //Assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string bookName)
        {
            return new Book(bookName);
        }
    }
}
