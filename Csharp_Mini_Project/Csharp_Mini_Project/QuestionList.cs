using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class QuestionList:List<Question>
    {
        
        public string FilePath { get; }
        public QuestionList(string filepath)
        {
            FilePath = filepath;
        }

        
        public new void Add(Question q)
        {   
            if(!this.Contains(q))
            {
                base.Add(q);
                this.Sort();
                File.AppendAllText(FilePath, q.ToString() + Environment.NewLine);

            }
        }
    }
}
