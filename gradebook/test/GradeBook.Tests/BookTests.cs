using System;
using System.Collections.Generic;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverage()
        {
            //Arrange
            var book = new Book("Manoj's Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //Act
            var result = book.GetStatistics();

            //Assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.Max);
            Assert.Equal(77.3, result.Min);
            Assert.Equal('B', result.LetterGrade);
        }

        [Fact]
        public void AddGradeIsFun()
        {
            //Arrange
            var book = new Book("Manoj's Book");
            List<double> testData = new List<double>() { 89.1, 90.5, 77.3, 101, -1, 0, 100 };
            foreach (var curItem in testData)
            {
                book.AddGrade(curItem);
            }

            //Act

            //Assert
            foreach (var curItem in testData)
            {
                Assert.True(book.Contains(89.1));
            }

        }
    }
}
