using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class Question : ICloneable, IComparable<Question>
    {
        // 
        public string Body { get; }
        public string Header { get; }
        public int Marks { get; }
        public AnswerList Answers { get; protected set; }
        public AnswerList CorrectAnswers { get; protected set; }

        public Question(string header, string body,  int marks) 
        { 
            Body = body;
            Header = header;
            Marks = marks;
        }
        public object Clone()
        {
            return this.Clone();
        }

        public override bool Equals(object? obj)
        {
            if(obj is not Question other)
                return false;

            return Header == other.Header && Body == other.Body;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Body, Header);
        }

        public int CompareTo(Question? other)
        {
            if (other == null) return 1;

            return this.Marks.CompareTo(other.Marks);
        }

        public override string ToString()
        {
            return $"{Header}\n{Body}\n{Answers}";
        }
    }
}
