using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Registry.Classes {
    internal class SupplyContract : Document {
        public string DocumentNumber { get; set; }
        public string DocumentDate { get; set; }
        public string GoodsType { get; set; }
        public int GoodsCount { get; set; }
        public override string GetDocumentInfo() {
            return $"Document number: {DocumentNumber}\nDocument date: {DocumentDate}\n" +
                $"Goods type: {GoodsType}\nGoods count: {GoodsCount}\n ";
        }
    }
}
