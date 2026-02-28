using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class ChooseOneQuestion:Question
    {

        public ChooseOneQuestion(string header, string body,  int marks, AnswerList answers, int correctAnswerID):base(body, header, marks) 
        {
            if (answers == null)
                throw new ArgumentNullException(nameof(answers));
            if (answers.Count < 2)
                throw new ArgumentException("There must be at least two answers to choose from");
            
            Answers = new AnswerList(answers);

            var correct = Answers.FirstOrDefault(a => a.ID == correctAnswerID);
            if (correct == null) 
                throw new ArgumentException("correctAnswerID must match an existing answer ID"); // no match was found

            CorrectAnswers = new AnswerList() { correct };
        }

    }
}
