using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Registry.Classes {
    internal class Registry {
        Document[] docArr;
        private int i;
        public Registry() 
        {
            docArr = new Document[10];
            i = 0;
        }
        public string AddDocument(Document doc) {

            docArr[i] = doc;
            i++;
            return "Document added";

        }
        public string GetInfo(Document doc) {
            foreach (var d in docArr) {
                if(d == doc) {
                    return d.GetDocumentInfo();
                }
            }
            return "Document not in registry";
        }
    }
}
