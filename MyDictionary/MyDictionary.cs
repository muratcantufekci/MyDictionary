using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,Y>
    {
        T[] keys;
        Y[] values;
        public MyDictionary()
        {
             keys = new T[0];
             values = new Y[0];
        }
        public void Add(T key,Y value)
        {
            T[] tempArray = keys;
            Y[] tempArray2 = values;

            keys = new T[keys.Length + 1];
            values = new Y[values.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                keys[i] = tempArray[i];
            }
            keys[keys.Length - 1] = key;

            for (int y = 0; y < tempArray2.Length; y++)
            {
                values[y] = tempArray2[y];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            
        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("The key is :" + keys[i] + "The value is :" + values[i]);
            }
        }

        public void ListById(int id)
        {
            Console.WriteLine("The value of "+ id + ". id is:" + values[id-1]);
        }
    }

    
}
