using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Geometric.Classes {
    internal class Rectangle : Shape
    {
        public int SideLenght { get; set; }
        public override string GetPerimeter() {
            return $"Rectangle perimeter: {4 * SideLenght}";
        }
        public override string GetSquare() {
            return $"Rectangle square: {SideLenght * SideLenght}";
        }
    }
}
