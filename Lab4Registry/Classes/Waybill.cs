using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Registry.Classes {
    internal class Waybill : Document {
        public string DocumentNumber { get; set; }
        public string DocumentDate { get; set; }
        public int DepartmentID { get; set; }
        public string FinalMonthSum { get; set; }
        public override string GetDocumentInfo() {
            return $"Document number: {DocumentNumber}\nDocument date: {DocumentDate}\n" +
                $"Department id: {DepartmentID}\nFinal Month sum: {FinalMonthSum}\n ";
        }
    }
}
