using Lab4Work.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Work.Classes {
    internal class Director : IPrintable {
        public string PositionPrint() {
            return "I am Director";
        }
    }
}
