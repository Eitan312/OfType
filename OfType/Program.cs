using OfType;

TypeFiftyNine fiftyNine = new TypeFiftyNine();
IEnumerable<int> res = fiftyNine.GetOfType<int>(new object[] { "dasdsa", 4, "dsasdas" });
Console.WriteLine(res.Count());
foreach (int s in res)
{
    Console.WriteLine(s);
}

