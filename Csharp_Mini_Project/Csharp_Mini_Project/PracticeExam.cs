using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(TimeOnly time, QuestionList questions, Subject subject)
        : base(time, questions, subject)
        {
        }
        private PracticeExam(PracticeExam other):base(other)
        { }
        public override object Clone()
        {
            return new PracticeExam(this);
        }

        public override string ShowExam()
        {
            string output = "";

            foreach (Question question in Questions) 
            {
                output += $"{question.Header}\n";
                output += $"{question.Body}\n";
                output += $"{question.Answers}\n";
                output += $"Correct Answer(s): {question.CorrectAnswers}\n\n";
            }
            return output;
        }
    }
}
