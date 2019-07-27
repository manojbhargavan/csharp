using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer()
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer()
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer()
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();

            string expected = "";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            //Arrange
            Customer customer1 = new Customer() { FirstName = "Bilbo" };
            Customer.IntanceCount++;
            Customer customer2 = new Customer() { FirstName = "Frodo" };
            Customer.IntanceCount++;
            Customer customer3 = new Customer() { FirstName = "Rosie" };
            Customer.IntanceCount++;

            //Act

            //Assert
            Assert.Equal(3, Customer.IntanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            //Arrange
            Customer customer1 = new Customer() { LastName = "Bilbo", EMail = "some@example.com" };
            var expected = true;
            //Act
            var actual = customer1.Validate();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastname()
        {
            //Arrange
            Customer customer1 = new Customer() { EMail = "some@example.com" };
            var expected = false;
            //Act
            var actual = customer1.Validate();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingEmail()
        {
            //Arrange
            Customer customer1 = new Customer() { EMail = "some@example.com" };
            var expected = false;
            //Act
            var actual = customer1.Validate();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastnameEmail()
        {
            //Arrange
            Customer customer1 = new Customer();
            var expected = false;
            //Act
            var actual = customer1.Validate();

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
