using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class AnswerList: List<Answer>
    {
        // Manual paramterless constructor since the below constructor override default constructor
        public AnswerList() { }

        // Allows making a copy of AnswerList, List<Answer>, Any collection of Answer
        public AnswerList(IEnumerable<Answer> other) : base(other)
        { }

        public override string ToString()
        {
            return string.Join("\n", this);
        }
    }
}
