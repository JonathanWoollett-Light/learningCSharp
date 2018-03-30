using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Useable : Item
    {
        public int Usages { get; private set; }//assuming 'use' would be a function of this class

        public Useable(string image, float weight, float value, string name, int usages) : base(image, weight, value, name)
        {
            Usages = usages;
        }
    }
}
