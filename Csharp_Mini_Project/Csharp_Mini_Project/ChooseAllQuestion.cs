using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class ChooseAllQuestion:Question
    {
        public ChooseAllQuestion(string header, string body,  int marks, AnswerList answers, List<int> correctAnswersIDs):base(body, header, marks)
        { 
            if (answers == null)
                throw new ArgumentNullException(nameof(answers));
            if (answers.Count < 2)
                throw new ArgumentException("There must be at least two answers to choose from");
            
            Answers = new AnswerList(answers);

            if (correctAnswersIDs == null)
                throw new ArgumentNullException(nameof(correctAnswersIDs));
            if (correctAnswersIDs.Count == 0)
                throw new ArgumentException("There must be at least one correct answer");

            if (correctAnswersIDs.Count != correctAnswersIDs.Distinct().Count())
                throw new ArgumentException("Duplicate correct answer IDs are not allowed");

            CorrectAnswers = new AnswerList();
            foreach (int correctAnswerID in correctAnswersIDs)
            {
                var correct = Answers.FirstOrDefault((a)=> a.ID == correctAnswerID);
                if (correct == null) throw new ArgumentException("correctAnswerID must match an existing answer ID");
                CorrectAnswers.Add(correct);
            }


        }
    }
}
