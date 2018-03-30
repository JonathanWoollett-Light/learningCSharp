using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Item
    {
        public float Weight { get; }
        public float Value { get; }
        public string Name { get; set; }
        public string Image { get; }

        public Item(string image, float weight, float value, string name)
        {
            Image = image;
            Weight = weight;
            Value = value;
            Name = name;
        }
    }
}
