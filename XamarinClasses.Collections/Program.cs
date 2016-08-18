using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClasses.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfNumbers();
            DictionaryOfCitizens();
            StackOfDoings();
            QueueOfPeople();

            Console.ReadKey();
        }

        static void ListOfNumbers()
        {                        
            List<int> numbers = new List<int>();
            
            numbers.Add(2);
            numbers.Add(50);
            numbers.Add(34);
            numbers.Add(69);

            numbers.Remove(69);

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Clear();

            if(numbers.Count == 0)
            {
                Console.WriteLine("Nothing");
            }

            int firstNumber = numbers[0];
            Console.WriteLine("This is the first number {0}", firstNumber);

        }

        static void DictionaryOfCitizens()
        {
            Dictionary<string, Citizen> citizens = new Dictionary<string, Citizen>();

            citizens.Add("12345678Z", new Citizen() { Age = 26, Name = "Catalina" });
            citizens.Add("40404040Y", new Citizen() { Age = 70, Name = "Federico" });

            if(!citizens.ContainsKey("40404040Y"))
            {
                citizens.Add("40404040Y", new Citizen() { Age = 18, Name = "Juan" });
            }
            


            foreach(KeyValuePair<string, Citizen> citizen in citizens)
            {
                Console.WriteLine("Age: {0} Name: {1}", citizen.Value.Age , citizen.Value.Name);
            }
        }

        static void StackOfDoings()
        {
            Stack<string> tasks = new Stack<string>();

            tasks.Push("Do meal");
            tasks.Push("Wake up");
            tasks.Push("Do a laundry");

            foreach(string task in tasks)
            {
                Console.WriteLine(task);
            }

            string firstAssigment = tasks.Pop();

            Console.WriteLine("My first assigment is {0}", firstAssigment);
        }

        static void QueueOfPeople()
        {
            Queue<Citizen> queueOfPeople = new Queue<Citizen>();

            queueOfPeople.Enqueue(new Citizen() { Age = 30, Name = "Carlos" });
            queueOfPeople.Enqueue(new Citizen() { Age = 19, Name = "Maria" });
            queueOfPeople.Enqueue(new Citizen() { Age = 40, Name = "Sonia" });
            queueOfPeople.Enqueue(new Citizen() { Age = 29, Name = "Jose" });

            Citizen firstCitizen = queueOfPeople.Dequeue();

            Console.WriteLine("Age {0} , Name {1}", firstCitizen.Age, firstCitizen.Name);
        }
    }
}
