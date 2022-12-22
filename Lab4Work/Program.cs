

using Lab4Work.Classes;
using Lab4Work.Interfaces;

var lst = new List<IPrintable>();

lst.Add(new Booker());
lst.Add(new Director());
lst.Add(new Worker());

foreach (var i in lst) {
    Console.WriteLine(i.PositionPrint());
}