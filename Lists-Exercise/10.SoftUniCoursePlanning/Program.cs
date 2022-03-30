using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine())!= "course start")
            {
                string[] commandElements = command.Split(':');
                string modify = commandElements[0];
                switch (modify)
                {
                    case"Add":
                        string lessonTitle = commandElements[1];
                        if (!(schedule.Contains(lessonTitle)))
                        {
                            schedule.Add(lessonTitle);
                        }
                        break;
                    case "Insert":
                        lessonTitle = commandElements[1];
                        int index = int.Parse(commandElements[2]);
                        if (!(schedule.Contains(lessonTitle)))
                        {
                            schedule.Insert(index, lessonTitle);
                        }
                        break;
                    case "Remove":
                        lessonTitle = commandElements[1];
                        if (schedule.Contains(lessonTitle))
                        {
                            schedule.Remove(lessonTitle);
                            if (schedule.Contains($"{lessonTitle}-Exercise"))
                            {
                                schedule.Remove($"{lessonTitle}-Exercise");
                            }
                        }
                        
                        break;
                    case "Swap":
                        lessonTitle = commandElements[1];
                        string lessonTitle1 = commandElements[2];
                        if (schedule.Contains(lessonTitle)&&schedule.Contains(lessonTitle1))
                        {
                            int index1 = schedule.IndexOf(lessonTitle);
                            int index2 = schedule.IndexOf(lessonTitle1);                           
                            string temp1 = lessonTitle;
                            string temp2 = lessonTitle1;
                            schedule.RemoveAt(index1);
                            schedule.Insert(index1, temp2);
                            schedule.RemoveAt(index2);
                            schedule.Insert(index2, temp1);
                            string exercise1 = ($"{lessonTitle}-Exercise");
                            string exercise2 = ($"{lessonTitle1}-Exercise");
                            if (schedule.Contains(exercise1))                         
                            {
                                index2 += 1;
                                temp2 = exercise1;
                                schedule.Remove(exercise1);
                                schedule.Insert(index2, temp2);
                                                              
                            }
                            if (schedule.Contains(exercise2))
                            {
                                index1 += 1;
                                temp1 = exercise2;
                                schedule.Remove(exercise2);
                                schedule.Insert(index1, temp1);
                                
                            }

                        }
                        break;
                    case "Exercise":
                        lessonTitle = commandElements[1];
                        int indexX = schedule.IndexOf(lessonTitle);
                        if (schedule.Contains(lessonTitle))
                        {
                            string exercise = ($"{lessonTitle}-Exercise");
                            schedule.Insert(indexX + 1, exercise);
                        }
                        else
                        {
                            schedule.Add(lessonTitle);
                            string exercise = ($"{lessonTitle}-Exercise");
                            schedule.Add(exercise);
                        }
                        break;
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{schedule[i]}");
            }
        }
    }
}
