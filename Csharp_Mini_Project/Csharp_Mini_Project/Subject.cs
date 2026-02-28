using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mini_Project
{
    internal class Subject
    {
        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Subject: {Name}";
        }
    }
}
