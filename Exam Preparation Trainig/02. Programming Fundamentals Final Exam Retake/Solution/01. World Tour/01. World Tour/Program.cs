using System;
using System.Linq;
using System.Text;


namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine(); // Hawai::Cyprys-Greece

            string command = Console.ReadLine(); //Add Stop:7:Romeю

            while (command != "Travel")
            {
                string[] commandInfo = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries); //InsertSpace, 5
                string commandName = commandInfo[0];

                if (commandName == "Add Stop")
                {
                    int Insertindex = int.Parse(commandInfo[1]);
                    string newStop = commandInfo[2];
                    if(Insertindex > -1 && Insertindex < stops.Length)
                    {
                        stops = stops.Insert(Insertindex, newStop);    
                    }
                    Console.WriteLine(stops);
                }
                else if (commandName == "Remove Stop")
                {             
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);
                    if ((startIndex > -1 && startIndex < stops.Length) && (endIndex > -1 && endIndex < stops.Length))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);         
                    }
                    Console.WriteLine(stops);
                }
                else if (commandName == "Switch")
                {
                    string oldString = commandInfo[1];
                    string newString = commandInfo[2];
                    if (oldString != newString && stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }              
                    Console.WriteLine(stops);
                }
                command = Console.ReadLine();
            }
          Console.WriteLine($"Ready for world tour! Planned stops: {stops}");       
        }
    }
}
     
