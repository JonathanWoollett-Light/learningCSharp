using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Sword : Item
    {
        public float Damage { get; }
        public float Speed { get; }

        public Sword(string image, float weight, float value, string name, float damage, float speed) : base(image, weight, value, name)
        {
            Damage = damage;
            Speed = speed;
        }
    }
}
