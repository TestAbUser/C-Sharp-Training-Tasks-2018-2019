using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Logging
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-09-04 13:11:59</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        public void PrintMenuOptions()
        {
            Console.WriteLine("Menu:" +
                              "\n1.Display array without parameters." +
                              "\n2.Display array with configurable size." +
                              "\n3.Display array with configurable content.");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-09-04 13:12:33</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        public void PrintArrayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select an option:" +
                              "\n1.Add." +
                              "\n2.AddRange." +
                              "\n3.Remove." +
                              "\n4.Insert.");
        }

        public void PrintConfigureSizeOption()
        {
            Console.WriteLine("Enter the size of the array.");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-09-02 13:59:40</DateOfCreation>
        /// <summary>
        /// Contains methods for displaying .
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dynamicArray"></param>
        public void PrintArray<T>(DynamicArray<T> dynamicArray) where T : new()
        {
            Console.WriteLine("Length = {0}" +
                              "\nCapacity = {1}", dynamicArray.Length, dynamicArray.Capacity);
            for (int i = 0; i < dynamicArray.Capacity; i++)
            {
                Console.WriteLine(dynamicArray[i]);
            }
            Console.WriteLine();
        }


    }
}
