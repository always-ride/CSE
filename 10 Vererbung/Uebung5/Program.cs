//Console.WriteLine(Man.Counter);

CreatePeople();
GC.Collect();
GC.WaitForPendingFinalizers();
GC.Collect();
//Console.WriteLine(Man.Counter);


static void CreatePeople()
{
    // TODO
}
