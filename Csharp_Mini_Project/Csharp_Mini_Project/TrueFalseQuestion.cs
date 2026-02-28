using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class TrueFalseQuestion: Question
    {
        private int _correctAnswerID;

        public int CorrectAnswerID
        {
            get { return _correctAnswerID; }
            set { if(value == 1 || value == 2) _correctAnswerID = value;
                else throw new ArgumentException("CorrectAnswerID must be 1 (True) or 2 (False).");
            }
        }

        public TrueFalseQuestion(string header, string body, int marks, int correctAnswerId):base( header, body, marks)
        {
            CorrectAnswerID = correctAnswerId;
            Answers = new AnswerList()
            {
                new Answer(1,"True"),
                new Answer(2,"False")
            };
            CorrectAnswers = new AnswerList()
            {
                Answers.First((a)=> a.ID == correctAnswerId)
            };
        }

       
    }
}
