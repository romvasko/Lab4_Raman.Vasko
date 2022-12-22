using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Registry.Classes {
    internal class EmployeeContract : Document {
        public string DocumentNumber { get; set; }
        public string DocumentDate { get; set; }
        public string ContractLastDate { get; set; }
        public string EmployeeName { get; set; }
        public override string GetDocumentInfo() {
            return $"Document number: {DocumentNumber}\nDocument date: {DocumentDate}\n" +
                $"Contract last date: {ContractLastDate}\nEmployee name: {EmployeeName}\n ";
        }
    }
}
