using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T>
    {

        public double capacity;
        public double count;
        public double index;
        public T item;
        public Array customList;



        public CustomList()
        {
            CreateArray();

            



        }

        //Create the basic Array
        public void CreateArray()
        {
            Array customlistArray = new Array[4];

            T[] customListArray = new T[4];

            CreateArrayCapacity();
            
        }

        //Create the Array capacity size---
            //based on the starting value always being 4, then as count increases so does capacity
        public void CreateArrayCapacity()
        {
            CustomList<T> capacity = new CustomList<T>();

            for (capacity = 0;  )
            capacity = 


        }


        public void Add(T item)
        {



        }



        



    }
}
