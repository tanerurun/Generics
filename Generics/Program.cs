using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();
            city.Add("Ankara");
            Console.WriteLine(city.Count);

            MyList<string> city2 = new MyList<string>();
            
            city2.add("Van");
            Console.WriteLine(city2.Count);
            Console.ReadKey();
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _temArray;
        public MyList()
        {
            _array = new T[0];//sıfır değerli bir array oluşturuyoruz.
        }
        public void add(T item)
        {
            _temArray = _array;//önceki arraylar tutmak için
            _array = new T[_array.Length + 1];
            for(int i=0;i<_temArray.Length;i++)
            {
                _array[i] = _temArray[i];//_array elemanlarını _temArray aktarıyoruz.
            }
            _array[_array.Length-1] = item;
        }
        public int Count//count sadece get değer alıyor 
        {
            get { return _array.Length; }
        }
    }
}
