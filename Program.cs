using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousResultRoaster
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. This is the number of students who sat for the exam.");

            int Students = new Random().Next(500,1000);
            Console.WriteLine(Students);

            int Pass = 0;
            int Average = 0;
            int Fail = 0;

        
            List<int> Scores = new List<int>();
            for(int i = 0; i < Students; i++)
                {
                    int Score = new Random().Next(1,100);                   
                    
                    if (Score>= 70)
                    {
                        Pass = Pass + 1;
                    }
                    else if (Score>=50 && Score<=69)
                    {
                        Average = Average + 1;
                    }
                    else if (Score<50)
                    {
                        Fail = Fail + 1;
                    }
                    Scores.Add(Score);
                    
                }
                

            Console.WriteLine("Below are the number of students that passed the exam by getting a score of 70 and above");     
            Console.WriteLine(Pass);
            Console.WriteLine("Below are the number of students who got the average score between 50-69"); 
            Console.WriteLine(Average);
            Console.WriteLine("Below are the number of students who failed the exam by getting a score below 50"); 
            Console.WriteLine(Fail);
            Console.WriteLine ("Below are the scores of all the students who took the exam");

            for (int i = 0; i <Students; i++)
            {
                Console.Write(Scores[i] + " , ");
            }
        }
    }
}
