using System.Collections;
using System;

namespace ArrayListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Console.WriteLine("Enter 3 Person's Name and Age : ");
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return "Name : " + Name + ", Age : " + Age;
        }
    }
}