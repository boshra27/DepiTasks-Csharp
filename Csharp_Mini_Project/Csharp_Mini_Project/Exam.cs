using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal abstract class Exam:ICloneable, IComparable<Exam>
    {
        public TimeOnly Time {  get; set; }
        public QuestionList Questions { get; }
        public int NoOfQuestions => Questions.Count;
        public int TotalMarks => Questions.Sum((q) => q.Marks);
        public Dictionary<Question, AnswerList> StudentAnswers { get;}
        public ExamMode Mode { get; set; }
        public Subject Sub {  get; set; }

        protected Exam(TimeOnly time, QuestionList questions, Subject subject)
        {
            Time = time;
            Mode = ExamMode.Starting;
            Questions = questions;
            Sub = subject;
            StudentAnswers = new Dictionary<Question, AnswerList>();
        }
        protected Exam(Exam other)
        {
            Time = other.Time;
            Mode = other.Mode;
            Sub = other.Sub;

            Questions = new QuestionList(other.Questions.FilePath);
            foreach (var q in other.Questions)
                Questions.Add((Question)q.Clone());

            StudentAnswers = new Dictionary<Question, AnswerList>();
            foreach (var pair in other.StudentAnswers)
            {
                StudentAnswers.Add(
                    (Question)pair.Key.Clone(),
                    new AnswerList(pair.Value)
                );
            }
        }
        public abstract object Clone();//

        // Method used for correction
        public int Correct()
        {
            int score = 0;
            foreach(var pair in StudentAnswers)
            {
                Question question = pair.Key;
                AnswerList studentAnswers = pair.Value;

                var correctAnswer = question.CorrectAnswers;

                if(studentAnswers.Count == correctAnswer.Count &&
                    !studentAnswers.Except(correctAnswer).Any())
                {
                    score += question.Marks;
                }
            }
            return score;
        }


        public abstract string ShowExam();

        public int CompareTo(Exam? other)
        {
            if(other == null) return 1;
            return TotalMarks.CompareTo(other.TotalMarks);
        }
    }
}
