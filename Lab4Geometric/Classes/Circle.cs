using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Geometric.Classes {
    internal class Circle : Shape 
    {
        public int Radius { get; set; }
        public override string GetPerimeter() {
            return $"Circle perimeter: {2 * 3.14 * Radius}";
        }
        public override string GetSquare() {
            return $"Circle square: {3.14 * Radius * Radius}";
        }
    }
}
