using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Potion : Useable
    {
        public float EffectLength { get; }//in seconds
        public float HealthPerSecond { get; }

        public Potion(string image, float weight, float value, string name, int usages, float effectLength, float healthPerSecond) : base(image, weight, value, name, usages)
        {
            EffectLength = effectLength;
            HealthPerSecond = healthPerSecond;
        }
    }
}
