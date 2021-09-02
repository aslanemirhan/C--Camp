using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Istanbul");
            sehirler.Add("Istanbul");
            sehirler.Add("Istanbul");
            sehirler.Add("Istanbul");
            sehirler.Add("Istanbul");

            Console.WriteLine(sehirler.Count);
            Console.WriteLine("--------------------");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");

            Console.Write(sehirler2.Count);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
            
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i <_tempArray.Length ; i++)
            {
                _tempArray[i] = _array[i];
            }

            _array[_array.Length - 1] = item;
        }
            

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
