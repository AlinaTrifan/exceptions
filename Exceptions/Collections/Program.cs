using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStringList = new List<string>();
            //punem in lista
            myStringList.Add("C#");
            myStringList.Add("Java");
            myStringList.Add("javascript");
            myStringList.Add("python");

            //afisam lista
            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            //verific daca Java e in lista si apoi o scot
            if (myStringList.Contains("Java"))
            {
                myStringList.Remove("Java");
            }

            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            Zoo myAwesomeZoo = new Zoo();

            foreach (var animal in myAwesomeZoo.Animals)
            {

                Console.WriteLine($"This is a {animal.Name} and it's a {animal.Gender}");
            }

            Console.WriteLine("__________stack");
            Stack<string> myStack = new Stack<string>();
            myStack.Push("C#");
            myStack.Push(".NET");
            myStack.Push("SQL");

            int count = myStack.Count;
           
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myStack.Pop());
            }
            //faceam pop la un element si i-ul se tot schimba si scadea cu cate 1 de fiecare pop
            //for (int i = 0; i < myStack.Count; i++)
            //{
            //    Console.WriteLine(myStack.Pop());
            //}

            Console.WriteLine("__________queue");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("C#");
            myQueue.Enqueue(".NET");
            myQueue.Enqueue("SQL");

            int countQ = myQueue.Count;

            for (int i = 0; i < countQ; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.WriteLine("__________dictionary");
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
            dict.Add("Gigi", 30.23m);
            dict.Add("Ion", 23.23m);
            dict.Add("Mos Craciun", 0m);

            foreach (var record in dict)
            {
                Console.WriteLine($"{record.Key}:{record.Value}");
            }
            //aici pot pune doar clase care implementeaza interfata asta
            List<Interface1> landAnimals = new List<Interface1>();
            Dictionary<string, List<string>> keyListDictionary = new Dictionary<string, List<string>>();
        }
    }
}
