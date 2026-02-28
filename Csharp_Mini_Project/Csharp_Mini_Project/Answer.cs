using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class Answer
    {
        // Making Answer immutable to prevent change from outside
        public int ID { get; }
        public string Text { get; }

        public Answer(int iD, string text) 
        { 
            ID = iD;
            Text = text;
        }

        public override bool Equals(object? obj)
        {
            if(obj is not Answer other)
                return false;

            return ID == other.ID;
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        public override string ToString() 
        { 
            return $"{ID}. {Text}";
        }

    }
}
