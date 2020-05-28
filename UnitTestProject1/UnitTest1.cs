using System;
using Custom_List_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Test to confirm existence of the Array
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

        //Test to confirm correct Array Capacity amount---i.e. number of available "memory slots"
        [TestMethod]
        private void Confirm_Array_Capacity()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            
            double expectedCapacity = 4;
            double actualCapacity;
            

            //Act
            actualCapacity = customList.capacity;

            //Assert
            Assert.AreEqual(actualCapacity, expectedCapacity);

        }

        //Test to confirm existence of functionality to increase the Array capacity
        [TestMethod]
        private void Increase_Array_Capacity()
        {

            //Arrange
            CustomList<int> customList = new CustomList<int>();

            double expectedCapacity = 8;
            double actualCapacity;

            //Act
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(1);

            actualCapacity = customList.capacity;

            //Assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        //Test to confirm correct Array Count---i.e. number of present items in available "memory slots"
        [TestMethod]
        private void Confirm_Array_Count()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(1);
            double expectedCount = 4;
            double actualCount;
   

            //Act
            actualCount = customList.count;

            //Assert
            Assert.AreEqual(actualCount, expectedCount);

        }

        [TestMethod]
        private void ConfirmCountIncrease()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            double expectedCount;
            double actualCount;

            //Act
            actualCount == expectedCount;

            //Assert
            Assert.AreEqual(actualCount, expectedCount);



        }


        
        // test that adding first item added goes to index 0
        // test that 


        


    }
}
