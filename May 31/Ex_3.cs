using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Question
    {
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Options { get; set; }
       
    }

    class MainProgram
    { 
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>
            {
                new Question
                {
                    Text = "Which is the capital city of India?",
                    CorrectAnswer = "New Delhi",
                    Options = new List<string> {"Jaipur","Patna","New Delhi","Mumbai"}
                },
                new Question
                {
                    Text = "Solve the Given Equation (2 + 2) ?",
                    CorrectAnswer = "4",
                    Options = new List<string> { "3", "4", "5", "6" }
                },
                new Question
                {
                    Text = "Which is the largest planet in our solar system?",
                    CorrectAnswer = "Jupiter",
                    Options = new List<string> { "Earth", "Mars", "Jupiter", "Saturn" }
                },
                new Question
                {
                    Text = "What is the chemical symbol for water?",
                    CorrectAnswer = "H2O",
                    Options = new List<string> { "CO2", "H2O", "O2", "NaCl" }
                },
                new Question
                {
                    Text = "Who wrote the play 'Romeo and Juliet'?",
                    CorrectAnswer = "William Shakespeare",
                    Options = new List<string> { "Charles Dickens", "Mark Twain", "William Shakespeare", "Jane Austen" }
                }
            };

            // Score variable to keep track of correct answers
            int score = 0;

            foreach (var question in questions)
            {
                //Display the question
                Console.WriteLine(question.Text);

                // Display options
                foreach (var option in question.Options)
                {
                    Console.WriteLine($"- {option}");
                }
     
                // User input Answer
                Console.Write("Your answer: ");
                string answer = Console.ReadLine();

                // Check if the answer is correct
                if (answer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                    Console.WriteLine("\nYour answer is Correct!\n");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {question.CorrectAnswer}\n");
                }
            }
            Console.WriteLine($"Your total score is: {score}/{questions.Count}");
        }
    }
}
