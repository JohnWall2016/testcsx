#! "netcoreapp2.1"
#r "Utils/bin/Debug/netstandard2.0/Utils.dll"

using Utils;

//foreach(var info in Encoding.GetEncodings())
//    Console.WriteLine(info.Name);

//#r "nuget: System.Text.Encoding.CodePages, 4.5.0"
//Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
//Encoding chinese = Encoding.GetEncoding("GB18030");
//Console.WriteLine(chinese.EncodingName);

//Console.WriteLine(DateTime.Now.TimeOfDay);
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.Now.GetType().BaseType);
//Console.WriteLine(DateTime.Now.Kind);
//Console.WriteLine(DateTime.Today);
//Console.WriteLine(DateTime.Today.DayOfYear);

//typeof(DateTime).BaseType.WriteLine();
//typeof(DateTimeOffset).BaseType.WriteLine();
//
//var local = DateTime.Now;
//var utc = local.ToUniversalTime();
//local.WriteLine();
//utc.WriteLine();
//(local == utc).WriteLine();
//
//var local2 = DateTimeOffset.Now;
//var utc2 = local2.ToUniversalTime();
//local2.WriteLine();
//utc2.WriteLine();
//(local2 == utc2).WriteLine();
//
//var zone = TimeZone.CurrentTimeZone;
//zone.StandardName.WriteLine();
//zone.DaylightName.WriteLine();
//
//for (var m = 1; m <= 12; m++)
//{
//    var dt = new DateTime(2018, m, 1);
//    zone.IsDaylightSavingTime(dt).WriteLine();
//}
//
//var daylight = zone.GetDaylightChanges(2015);
//daylight.Start.ToString("M").WriteLine();
//daylight.End.ToString("M").WriteLine();
//daylight.Delta.WriteLine();
//
//foreach (var z in TimeZoneInfo.GetSystemTimeZones())
//    z.Id.WriteLine();

//2.ToString("C").WriteLine();
//50.ToString(@"#0").WriteLine();

//var a = new int[]{1,2,3,4};
//Console.WriteLine(a.GetType());
//
//a = new int[3];
//Console.WriteLine(a.GetType());
//Console.WriteLine(a.GetType().Assembly);
//Console.WriteLine(a.GetType().BaseType);
//Console.WriteLine(a.GetType().BaseType.Assembly.Location);
//
//var b = new[] { "a", "b" };
//Console.WriteLine(b.GetType());
//
//string[] c = { "c", "d" };
//Console.WriteLine(c.GetType());

//void show<T>(IList<T> elems)
//{
//    "[".Write();
//    int len = elems.Count;
//    if (len > 0)
//    {
//        if (len > 1)
//        {
//            for (var i = 0; i < len - 1; i++)
//            {
//                $"{elems[i]}, ".Write();
//            }
//        }
//        $"{elems[len-1]}".Write();
//    }
//    "]".WriteLine();
//}
//

void show<T>(IEnumerable<T> elems)
{
    var str = string.Join(", ", elems);
    $"[{str}]".WriteLine();
}

//var subwords = words.GetRange(2, 2);
//show(subwords);

//class Person
//{
//    internal string Name { get; set; }
//    internal Person() {}
//    internal Person(string name) { Name = name; }
//
//    internal class Nest {}
//}
//
//var p = new Person { Name = "Peter" };
//p.Name.WriteLine();
//typeof(Person).WriteLine();
//typeof(Person.Nest).WriteLine();

IEnumerable<char> query = "Not what you might expect";
string vowels = "aeiou";

for (int i = 0; i < vowels.Length; i++)
{
    var vowel = vowels[i];
    query = query.Where (c => c != vowel);
}

foreach (char c in query) Console.Write (c);
