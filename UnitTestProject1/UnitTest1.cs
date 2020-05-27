using System;
using Custom_List_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        private void Create_Array()
        {
            //Arrange
            CustomList customList = new CustomList();

            //Act
            customList = new CustomList();

            //Assert
            Assert.IsNotNull(customList);

        }


        [TestMethod]
        private void Confirm_Array_Capacity()
        {
            //Arrange
            CustomList customList = new CustomList();
            
            double capacity = 4;
            double expectedCapacity = capacity;
            double actualCapacity;
            double index = capacity;

            //Act
            actualCapacity = expectedCapacity - capacity;

            //Assert
            Assert.AreEqual(actualCapacity, capacity);

        }


        [TestMethod]
        private void Increase_Array_Capacity()
        {
            //Arrange
            CustomList customList = new CustomList();
            double capacity = 4;
            double increaseIndex;
            bool indexDoesIncrease = true;

            //Act
            increaseIndex = capacity ++;


            //Assert
            Assert.IsTrue(indexDoesIncrease);
        }



        [TestMethod]
        private void Decrease_Array_Capacity()
        {

            //Arrange
            CustomList customList = new CustomList();
            double capacity = 4;
            double decreaseIndex;
            bool indexDoesDecrease = true;

            //Act
            decreaseIndex = capacity--;

            //Assert
            Assert.IsTrue(indexDoesDecrease);


        }

        [TestMethod]
        private void Confirm_Array_Count()
        {


        }

    }
}
