using OfType;

TypeFiftyNine fiftyNine = new TypeFiftyNine();
IEnumerable<string> res = fiftyNine.GetOfType<string>(new object[] { "dasdsa", 4, "dsasdas" });
Console.WriteLine(res.Count());
foreach (string s in res)
{
    Console.WriteLine(s);
}