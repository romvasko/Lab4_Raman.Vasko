using Lab4Work.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Work.Classes {
    internal class Worker : IPrintable {
        public string PositionPrint() {
            return "I am Worker";
        }
    }
}
