using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class FinalExam : Exam
    {
        private FinalExam(FinalExam other) : base(other)
        {
        }
        public FinalExam(TimeOnly time, QuestionList questions, Subject subject) 
            : base(time, questions, subject)
        {
        }
        public override object Clone()
        {
            return new FinalExam(this);
        }

        public override string ShowExam()
        {
            string output="";

            foreach (Question question in Questions) 
            {
                output += $"{question.Header}\n";
                output += $"{question.Body}\n";
                output += $"{question.Answers}\n\n";
            }

            return output;
        }
    }
}
