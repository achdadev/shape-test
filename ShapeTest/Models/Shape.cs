using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest.Models
{
    public class Shape
    {
        public string? Id { get; set; }
        public float Width { get; set; } 
        public float Height { get; set; }
        public int AmountOfSides { get; set; }
        public float[] Position { get; set; } = new float[3];
        public float Scale { get; set; }
        public float[] Rotation { get; set; } = new float[3];
    }
}
