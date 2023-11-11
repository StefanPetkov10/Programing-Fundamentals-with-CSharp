using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("StePet", 26);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
        }
    }

    public class Student
    {
        public Student(string name, int age)
        {
            Name = name;             //Конструктора се използва за инециализация на нашия клас/ на нащия обект
            Age = age;              //Ползваме ги да създаваме обекти
        }                          
        public string Name { get; set; }

        public int Age { get; set; }
       }
        
    }


