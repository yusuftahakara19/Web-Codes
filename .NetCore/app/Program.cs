using System;
using System.Data;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    class Question
    {
        public Question(string text, string[] choices, string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }

        public Boolean checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }

    class Quiz
    {

        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }

        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }

        public Question GetQuestion()
        {
            return this.Questions[QuestionIndex];
        }

        public void DisplayQuestion()
        {
            var q = GetQuestion();
            this.DisplayProgress();

            Console.WriteLine(this.QuestionIndex + ") " + q.Text);
            foreach (string a in q.Choices)
            {
                Console.WriteLine($"-{a}");
            }
            Console.Write("Cevabınız : ");
            var answer = Console.ReadLine();
            this.Guess(answer);
        }

        private void Guess(string answer)
        {
            var question = GetQuestion();
            if (question.checkAnswer(answer))
                this.Score += 10;

            this.QuestionIndex++;
            if (this.QuestionIndex < this.Questions.Length)
                this.DisplayQuestion();
            else
                this.DisplayScore();


        }

        private void DisplayScore()
        {
            Console.WriteLine("Score : " + this.Score);
        }

        private void DisplayProgress()
        {
            if (this.QuestionIndex < this.Questions.Length)
                Console.WriteLine($"Question {this.QuestionIndex + 1} of {this.Questions.Length}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question("En iyi programalama dili?", new string[] { "C#", "Java", "Python", "C++" }, "C#");
            Question q2 = new Question("En popüler programalama dili?", new string[] { "C#", "Java", "Python", "C++" }, "C#");
            Question q3 = new Question("En çok kazandıran programalama dili?", new string[] { "C++", "Python", "Java", "C#" }, "C#");

            Question[] questions = new Question[] { q1, q2, q3 };

            Quiz quiz = new Quiz(questions);
            quiz.DisplayQuestion();



        }
    }
}