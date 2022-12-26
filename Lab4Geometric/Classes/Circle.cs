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
            return String.Format($"Circle perimeter: {2 * 3.14 * Radius}");
        }
        public override string GetSquare() {
            return String.Format($"Circle square: {3.14 * Radius * Radius}");
        }
    }
}
