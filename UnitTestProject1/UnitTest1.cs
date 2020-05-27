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
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList = new CustomList<int>();

            //Assert
            Assert.IsNotNull(customList);

        }


        [TestMethod]
        private void Confirm_Array_Capacity()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            
            // double capacity = 4;
            double expectedCapacity = 4;
            double actualCapacity;
            // double index = capacity;

            //Act
            actualCapacity = customList.Capacity;

            //Assert
            Assert.AreEqual(actualCapacity, expectedCapacity);

        }


        [TestMethod]
        private void Increase_Array_Capacity()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 8;
            int actual;

            //Act
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(1);

            actual = customList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // test that Count goes up
        // test that adding first item added goes to index 0
        // test that 





        [TestMethod]
        private void Decrease_Array_Capacity()
        {

            //Arrange
            CustomList<int> customList = new CustomList<int>();
            double capacity = 4;
            double decreaseIndex;
            bool indexDoesDecrease = true;
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(1);

            //Act
            decreaseIndex = capacity--;
            customList.Remove(3);

            //Assert
            Assert.IsTrue(indexDoesDecrease);


        }

        [TestMethod]
        private void Confirm_Array_Count()
        {


        }

    }
}
