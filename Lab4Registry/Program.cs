
using Lab4Registry.Classes;

var reg = new Registry();

var doc1 = new SupplyContract() {
    DocumentNumber = "1",
    DocumentDate = "12.06.2018",
    GoodsCount = 12,
    GoodsType = "Cookie"
};

var doc2 = new EmployeeContract() {
    DocumentNumber = "2",
    DocumentDate = "13.06.2018",
    ContractLastDate = "15.06.2020",
    EmployeeName = "John"
};

var doc3 = new Waybill() {
    DocumentNumber = "3",
    DocumentDate = "23.09.2018",
    DepartmentID = 3,
    FinalMonthSum = "7894652"
};

var doc4 = new Waybill() {
    DocumentNumber = "4",
    DocumentDate = "23.09.2018",
    DepartmentID = 3,
    FinalMonthSum = "7894752"
};

Console.WriteLine(reg.AddDocument(doc1));
Console.WriteLine(reg.AddDocument(doc2));
Console.WriteLine(reg.AddDocument(doc3));

Console.WriteLine(reg.GetInfo(doc1));
Console.WriteLine(reg.GetInfo(doc2));
Console.WriteLine(reg.GetInfo(doc3));
Console.WriteLine(reg.GetInfo(doc4));


