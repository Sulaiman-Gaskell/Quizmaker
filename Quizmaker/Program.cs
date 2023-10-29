using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        Console.WriteLine(currentDirectory);
        string filePath = Path.Combine(currentDirectory, "questions.txt");
        List<string> lines = File.ReadAllLines(filePath).ToList();

        Random rand = new Random();
        int counter = 0;
        int correct = 0;

        while (counter < 5)
        {
            int randomIndex = rand.Next(0, lines.Count);
            string randomLine = lines[randomIndex];
            string[] qAndA = randomLine.Split(',');
            Console.WriteLine(qAndA[0]);
            string answer = Console.ReadLine();
            if (answer.ToLower() == qAndA[1].ToLower()){correct++;}
            counter++;
        }
        Dictionary<int, string> grades = new Dictionary<int, string>();
        grades[5] = "A";
        grades[4] = "B";
        grades[3] = "C";
        grades[2] = "D";
        grades[1] = "E";
        grades[0] = "F";

       foreach (int key in grades.Keys) 
       {
            if (key == correct)
            {
                string grade = grades[key];
                Console.WriteLine(grade);
            }
       }
            
    }
}