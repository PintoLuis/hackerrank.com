using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerRank
{
    class Solution
    {
        static void Main(String[] args)
        {
			string[] inputs = Console.ReadLine().Split();
			string firstName = inputs[0];
			string lastName = inputs[1];
			int id = Convert.ToInt32(inputs[2]);
			int numScores = Convert.ToInt32(Console.ReadLine());
			inputs = Console.ReadLine().Split();
			int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");
        }
        

        class Person
            {
                protected string firstName;
                protected string lastName;
                protected int id;

                public Person() { }
                public Person(string firstName, string lastName, int identification)
                {
                    this.firstName = firstName;
                    this.lastName = lastName;
                    this.id = identification;
                }
                public void printPerson()
                {
                    Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
                }
            }

        class Student : Person
        {
            private int[] testScores;
            private char grade;

            public Student(string firstName, string lastName, int id, int[] scores)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = id;
                this.testScores = scores;
            }

            public char calculate()
                {
                    int totalNotes = 0;
                    int average = 0;

                    for (int i = 0; i < testScores.Length; i++)
                    {
                        totalNotes += testScores[i];
                    }

                    average = totalNotes / testScores.Length;

                if (average < 40)
                    grade = 'T';
                else if (40 <= average && average < 50)
                    grade = 'D';
                else if (55 <= average && average < 70)
                    grade = 'P';
                else if (70 <= average && average < 80)
                    grade = 'A';
                else if (80 <= average && average < 90)
                    grade = 'E';
                else if (90 <= average && average <= 100)
                    grade = 'O';
                
                return grade;
                }
        }
    }
}
