using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T> : IEnumerable
    {

        private int capacity = 0;
        private int count;
        public int Count { get; }
        public int index;
        public T item;
        public T[] customList;



        public CustomList()
        {
            CreateArray();

        }

        //Create the basic Array
        public void CreateArray()
        {
            //Array customlistArray = new Array[4];

            T[] customListArray = new T[4];

            CreateArrayCapacity();

        }

        //Create the Array capacity size---
        //based on the starting value always being 4, then as count increases so does capacity
        public void CreateArrayCapacity()
        {
            //CustomList<T> capacity = new CustomList<T>();

            if (capacity <= 0)
            {
                capacity = 4;
            }
           
        
            while (capacity == count)
            {
                capacity++;
            }
        }

     
        public void Add(T item)
        {

            if (count == capacity)
            {
                T[] newCustomListArray = new T[capacity * 2];
            }

            customList[count] = item;
            count++;
        }

        List

        //public void AddItemToArray()
        //{
        //    if (item = new Array<item>)
        //    {
        //        item.add(customList);

        //    }

        //    while (capacity >= count)
        //    {
        //        index++;
        //    }

        //    while (customList.count == capacity)
        //    {
        //        capacity++;
        //    }

        //}

        public void RemoveItemFromArray()
        {
           if (count >= capacity)
           {
                item.remove(customList);

           }
            

           

        }

        public interface GetEnumeration()
            {



            }
            

        
            
           


        
            


    }



        



}

