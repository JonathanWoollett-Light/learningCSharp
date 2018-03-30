using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class ThrowingSpear : Useable
    {
        public float Damage { get; }
        public float Range { get; }

        public ThrowingSpear(String image, float weight, float value, String name, int usages, float damage, float range) : base(image, weight, value, name, usages)
        {
            Damage = damage;
            Range = range;
        }
    }
}
