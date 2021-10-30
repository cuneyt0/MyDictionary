using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<int, string> users = new MyDictionary<int, string>();

            users.Add(1, "Ahmet");
            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }
          
        }
    }
     
    class MyDictionary<TKeys,TValues>
    {
        TKeys[] key;
        TValues[] value;

        public MyDictionary()
        {
            key = new TKeys[0];
            value = new TValues[0];
        }

        public void Add(TKeys keyitems, TValues valueitems)
        {
            TKeys[] tempkey = key;
            key = new TKeys[key.Length + 1];
            TValues[] tempvalue = value;
            value = new TValues[value.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                key[i] = tempkey[i];
            }
            key[key.Length - 1] = keyitems;

            for (int i = 0; i < tempvalue.Length; i++)
            {
                value[i] = tempvalue[i];

            }
            value[value.Length - 1] = valueitems;
        }
        public TValues[] Value
        {
            get { return value; }
        }
        public TKeys[] Keys
        {
            get { return key; }
        }
    }
}
