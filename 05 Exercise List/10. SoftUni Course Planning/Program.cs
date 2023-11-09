using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lessons = Console.ReadLine()
                               .Split(", ")
                               .ToList();

            string command = " ";
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] Arr1 = command.Split(':').ToArray();
                string typecommand = Arr1[0];
                switch (typecommand)
                {
                    case "Add":
                        if (!Lessons.Contains(Arr1[1]))
                        {
                            Lessons.Add(Arr1[1]);
                        }
                        break;

                    case "Insert":
                        if (!Lessons.Contains(Arr1[1]))
                        {
                            int index = int.Parse(Arr1[2]);
                            Lessons.Insert(index, Arr1[1]);
                        }
                        break;

                    case "Remove":
                        if (Lessons.Contains(Arr1[1]))
                        {
                            Lessons.Remove(Arr1[1]);
                            string firstex = Arr1[1] + "-Exercise";

                            if (Lessons.Contains(firstex))
                            {
                                Lessons.Remove(firstex);
                            }
                        }
                        break;

                    case "Swap":

                        bool exist1 = Lessons.Contains(Arr1[1]);
                        bool exist2 = Lessons.Contains(Arr1[2]);
                        if (exist1 == true && exist2 == true)
                        {
                            string firstless = Arr1[1];
                            string secondless = Arr1[2];

                            int firstlessindex = Lessons.FindIndex(a => a.Contains(Arr1[1]));
                            int secondindex = Lessons.FindIndex(a => a.Contains(Arr1[2]));

                            string firstex = firstless + "-Exercise";
                            string secondex = secondless + "-Exercise";

                            Lessons.RemoveAt(firstlessindex);
                            Lessons.Insert(firstlessindex, secondless);


                            Lessons.RemoveAt(secondindex);
                            Lessons.Insert(secondindex, firstless);

                            if (Lessons.Contains(secondex))
                            {
                                Lessons.Remove(secondex);
                                Lessons.Insert(firstlessindex + 1, secondex);
                            }

                            if (Lessons.Contains(firstex))
                            {
                                // Lessons.RemoveAt(secondindex + 1);
                                Lessons.Remove(firstex);
                                Lessons.Insert(secondindex + 1, firstex);
                            }
                        }

                        break;

                    case "Exercise":
                        string Exersise1 = " ";
                        if (!Lessons.Contains(Arr1[1]))
                        {
                            Exersise1 = Arr1[1] + "-Exercise";
                            Lessons.Add(Arr1[1]);
                            Lessons.Add(Exersise1);
                        }
                        else
                        {
                            Exersise1 = Arr1[1] + "-Exercise";
                            int lessindex3 = Lessons.FindIndex(a => a.Contains(Arr1[1]));
                            Lessons.Insert(lessindex3 + 1, Exersise1);
                        }
                        break;
                }

            }
            PrinCourses(Lessons.Distinct().ToList());
        }

        static void PrinCourses(List<string> Courses)
        {
            for (int i = 0; i <= Courses.Count - 1; i++)
            {
                Console.WriteLine($"{i + 1}.{Courses[i]}");
            }
        }
    }
}