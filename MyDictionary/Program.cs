using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "Muratcan");
            myDictionary.Add(2, "Semih");
            myDictionary.Add(3, "Uğur");

            myDictionary.List();

            Console.WriteLine("Enter the id of customer:");
            int id = int.Parse(Console.ReadLine());
            myDictionary.ListById(id);
            Console.ReadKey();
        }
    }
}
