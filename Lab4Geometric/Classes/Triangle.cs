using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Geometric.Classes {
    internal class Triangle : Shape
    {
        public int Height { get; set; }
        public int SideLenght { get; set; }
        public override string GetPerimeter() {
            return $"Triangle perimeter: {3 * SideLenght}";
        }
        public override string GetSquare() {
            return $"Triangle square: {0.5 * Height * SideLenght}";
        }
    }
}
