using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryClass
{
    class MyDictonary<K, V>
    {
        K[] keys;
        V[] values;


        public MyDictonary()
        {
            keys = new K[0];
            values = new V[0];

        }
        public void Add(K key, V value)
        {
            K[] tempArrayKey = keys;
            V[] tempArrayValue = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
                values[i] = tempArrayValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void List()

        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Kelimeler Ve Anlamları: " + keys[i] + "  " + values[i]);
            }
        }
    }
}
