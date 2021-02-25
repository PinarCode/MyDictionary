using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> cities = new MyDictionary<string, string>();
            cities.Add("06", "Ankara");
            cities.Add("47", "Mardin");
            cities.Add("34", "İstanbul");
            cities.Add("01", "Adana");
            cities.ListItems();
        }
    }
}
