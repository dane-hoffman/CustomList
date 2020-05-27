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

        // test that Count goes up
        // test that adding first item added goes to index 0
        // test that 





        //[TestMethod]
        //private void Remove_Array_Capacity()
        //{

        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    double capacity = 4;
        //    double decreaseIndex;
        //    bool indexDoesDecrease = true;
        //    customList.Add(2);
        //    customList.Add(3);
        //    customList.Add(4);
        //    customList.Add(5);
        //    customList.Add(1);

        //    //Act
        //    decreaseIndex = capacity--;
        //    customList.Remove(3);

        //    //Assert
        //    Assert.IsTrue(indexDoesDecrease);


        //}



    }
}
