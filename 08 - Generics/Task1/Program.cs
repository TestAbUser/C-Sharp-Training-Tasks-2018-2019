using System;

/*
 На базе обычного массива (коллекции .NET не использовать) реализовать свой собственный класс 
DynamicArray, представляющий собой  массив с запасом. Элементами созданной коллекции могут быть только 
объекты, имеющие конструктор без параметров.
Класс должен содержать: 
1. Конструктор без параметров (создается массив емкостью 8 элементов). 
2. Конструктор с 1 целочисленным параметром (создается массив заданной емкости). 
3. Конструктор, который в качестве параметра принимает массив. 
4. Метод Add, добавляющий в конец массива один элемент. При нехватке места для добавления элемента
емкость массива должна расширяться в 2 раза. 
5. Метод AddRange, добавляющий в конец массива содержимое переданного массива. Обратите внимание, метод 
должен корректно учитывать число элементов в коллекции с тем, чтобы при необходимости расширения массива
делать это только один раз вне зависимости от числа элементов в добавляемой коллекции. 
6. Метод Remove, удаляющий из коллекции указанный элемент. Метод должен возвращать true, если удаление 
прошло успешно и false в противном случае. При удалении элементов реальная емкость массива не должна 
уменьшаться. 
7. Метод Insert, позволяющий добавить элемент в произвольную позицию массива (обратите внимание, может 
потребоваться расширить массив). Метод должен возвращать true, если добавление прошло успешно и false в 
противном случае. При выходе за границу массива должно генерироваться исключение ArgumentOutOfRangeException. 
8. Свойство Length – получение длины заполненной части массива. 
9. Свойство Capacity – получение реальной ёмкости массива. 
10. Индексатор, позволяющий работать с элементом с указанным номером. При выходе за границу массива 
должно генерироваться исключение ArgumentOutOfRangeException. 
*/

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-23 15:14:38</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-23 15:14:58</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        void Main()
        {
            int[] intArr = new int[] { 0, 2, 8, 0, 90, 0, 0 };
            char[] charArr = new char[] { 'j', 'a', 'b', 'c', 'd', 'j' };
            int intValue = 5;
            char charValue = 'v';
            DynamicArray<int> dynamicArr = new DynamicArray<int>();

            DynamicArray<int> dynamicArray = new DynamicArray<int>(new int[] { 0, 0, 0, 0, 1, 0, 10, 0 });
            Logging logging = new Logging();
            string option = null;
            switch (option)
            {
                case "1":
                    // Console.WriteLine("Array with capacity of 8 elements by default.");
                    logging.PrintArray(dynamicArr);
                    break;
                case "2":
                    // Console.WriteLine("Array without parameters.");
                    var size = ConvertToInt(Console.ReadLine());
                    DynamicArray<char> charArray = new DynamicArray<char>(size);
                    logging.PrintArrayMenu();
                    var optionForArrayMethods = Console.ReadLine();


                    ChangeArray(charArray, 'f', index: size);
                    logging.PrintArray(charArray);
                    break;
                case "3":
                    break;
            }



            logging.PrintArray(dynamicArr);

            logging.PrintArray(dynamicArray);

            charArray.AddRange(charArr);
            dynamicArray.Remove(intValue);
            charArray.Insert(charValue, 5);
            // dynamicArray.Insert(intValue, 60);
            logging.PrintArray(dynamicArr);
            logging.PrintArray(charArray);
            logging.PrintArray(dynamicArray);
            Console.ReadLine();
        }

        public DynamicArray<T> ChangeArray<T>(string option, DynamicArray<T> dynamicArray, 
            T value = default(T), int index = 0) where T : new()
        {
            switch (option)
            {
                case "1":
                    //var charf = Convert.ToChar(Console.ReadLine());
                    dynamicArray.Add(value);
                    break;
                case "2":
                    dynamicArray.AddRange(tArray);
                    break;
                case "3":
                    dynamicArray.Remove(index);
                    break;
                case "4":
                    dynamicArray.Insert(value, index);
                    break;

            }
            return dynamicArray;
        }
        public T SelectArrayType<T>(string option, string value) where T : new()
        {
            T convertedValue;
            Logging logging = new Logging();
            switch (option)
            {
                case "1":
                    convertedValue = ConvertToInt(value);
                    break;
                case "2":
                    var charValue = ConvertToChar(value);
                    break;
                case "3":
                    var doubleValue = ConvertToDouble(value);
                    break;
            }
            return;
        }

        public void SelectOption(string option)
        {
            switch (option)
            {

                case "1":
                    Console.WriteLine("Enter a value:");
                    var charf = Convert.ToChar(Console.ReadLine());

                    // 
                    break;
                case "2":
                    dynamicArray.AddRange(tArray);
                    break;
                case "3":
                    dynamicArray.Remove(index);
                    break;
                case "4":
                    dynamicArray.Insert(value, index);
                    break;
            }
        }

        public int ConvertToInt(string consoleLine)
        {
            int value = 0;
            var isInt = int.TryParse(Console.ReadLine(), out int parsedLine);
            if (isInt)
            {
                value = parsedLine;
            }
            else
            {
                Console.WriteLine("The value is not integer.");
            }

            return value;
        }


    }
}
