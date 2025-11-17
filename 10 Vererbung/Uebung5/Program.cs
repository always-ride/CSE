using Inheritance;

Console.WriteLine(Man.Counter);

CreatePeople();
GC.Collect();
GC.WaitForPendingFinalizers();
GC.Collect();
Console.WriteLine(Man.Counter);


static void CreatePeople()
{
    IPrintable m1 = new Man("Einstein", "Albert");
    var w1 = new Woman("Curie", "Marie");
    var m2 = new Man("Heisenberg", "Werner");

    m1.Print();
    w1.Print();

    Console.WriteLine(Man.Counter);
}
