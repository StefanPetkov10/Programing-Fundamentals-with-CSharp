using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            AddPeopleInList(people);

            PrintPeople(people);
        }

        static void AddPeopleInList(List<Person> people)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currName = personInfo[0];
                string currID = personInfo[1];
                int currAge = int.Parse(personInfo[2]);

                Person currPerson = new Person(currName, currID, currAge);


                Person personUpdate = people.Find(x => x.ID == currID);

                if (people.Contains(personUpdate))
                {
                    personUpdate.Name = currPerson.Name;
                    personUpdate.Age = currPerson.Age;
                }
                else
                {
                    people.Add(currPerson);
                }
            }
        }

        static void PrintPeople(List<Person> people)
        {
            people = people.OrderBy(x => x.Age).ToList();

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
