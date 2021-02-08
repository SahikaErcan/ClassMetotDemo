using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryUseIntro
{
    class MyDictionary<K,V> 
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempKey = keys; // anahtar ve değer verilerini geçici dizilere attık.
            V[] tempValue = values;

            keys = new K[keys.Length + 1]; // dizi boyutlarını arttırdık
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {// geçici dizilere attığımız değerleri yeni adresimize alıyoruz.
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            // en son eklenen değerleri aldık.
            keys[keys.Length - 1] = key; 
            values[values.Length - 1] = value;

        }

        public void Items()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(" " + keys[i] + " nolu müşteri " + values[i]);
            }
        }
       
        public int Count
        {
            get { return keys.Length; }
        }


    }
}
