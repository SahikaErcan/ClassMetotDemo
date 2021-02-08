using System;

namespace DictionaryUseIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customer = new MyDictionary<int, string>();
            customer.Add(0, "Kemal Sunal");
            customer.Add(1, "Kadir İnanır");
            customer.Add(2, "Türkan Şoray");
            customer.Add(3, "Cüneyt Arkın");
            customer.Add(4, "Filiz Akın");
            customer.Add(5, "Şener Şen");         
            customer.Add(6, "Hülya Koçyiğit");
            customer.Add(7, "Fatma Girik");
            
            Console.WriteLine("~~ Müşteri Bilgileri ~~");
            customer.Items();
            
            Console.WriteLine("Eleman Sayısı : " + customer.Count);
            Console.ReadKey();
        }
    }
}
