#! "netcoreapp2.1"
//#r "nuget: system.xml.linq, 2.1.0"
#r "Utils/bin/Debug/netstandard2.0/Utils.dll"

using Utils;
using System.Text.RegularExpressions;
using System.Linq;
using System.Xml.Linq;

using System.Threading;

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

//IEnumerable<char> query = "Not what you might expect";
//string vowels = "aeiou";
//
//for (int i = 0; i < vowels.Length; i++)
//{
//    var vowel = vowels[i];
//    query = query.Where (c => c != vowel);
//}
//
//foreach (char c in query) Console.Write (c);

//var words = "Not what you might expect".Split(' ');
//var pairs = words.Select((wd, i) => (i, wd));
//
//foreach(var (i, w) in pairs)
//    Console.WriteLine($"{i}: {w}");

//Regex.IsMatch("efg", "^efg$").WriteLine();

//var birds = new string[]
//{
//    "eagle",
//    "owl",
//    "sparrow",
//};
//
//var dogs = new string[]
//{
//    "Labrador",
//    "Poodle",
//    "Chihuahua",
//};
//
//var animals = new string[][]
//{
//    birds,
//    dogs,
//};
//
//var all = animals.SelectMany(clazz => clazz);
//
//show(all);

//var bench = XElement.Parse(
//@"<bench>
//  <toolbox>
//    <handtool>Hammer</handtool>
//    <handtool>Rasp</handtool>
//  </toolbox>
//  <toolbox>
//    <handtool>Saw</handtool>
//    <powertool>Nailgun</powertool>
//  </toolbox>
//</bench>");
//
//foreach (var e in bench.Descendants())
//{
//    "---------------------------".WriteLine();
//    $"{e.GetType()}:{e}".WriteLine();
//    "---------------------------".WriteLine();
//}
//
//"----------------------------------------".WriteLine();
//
//foreach (var e in bench.DescendantNodes())
//{
//    "---------------------------".WriteLine();
//    $"{e.GetType()}:{e}".WriteLine();
//    "---------------------------".WriteLine();
//}

//var tasks = new List<Task>();
//
//Task printAsync(object obj)
//{
//    return Task.Run(() =>
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"{obj} {Thread.CurrentThread.ManagedThreadId}|{Thread.CurrentThread.IsBackground}");
//    });
//}
//
//async Task printList()
//{
//    for (var i = 0; i < 10; i++)
//        await printAsync(i);
//    Console.WriteLine($"Done {Thread.CurrentThread.ManagedThreadId}|{Thread.CurrentThread.IsBackground}");
//    Test(
//         "aaa",
//    );
//}
//
//var awaiter = printList().GetAwaiter();
//Console.WriteLine($"aaa {Thread.CurrentThread.ManagedThreadId}|{Thread.CurrentThread.IsBackground}");
//Console.WriteLine($"bbb {Thread.CurrentThread.ManagedThreadId}|{Thread.CurrentThread.IsBackground}");
//awaiter.GetResult();

//Func<Task> delayedOutput = async () =>
//{
//    var task = Task.Delay(5000);
//    Console.WriteLine($"Task.Delay: {task.Id} - {task.GetType()}");
//    await task;
//    Console.WriteLine("Done");
//};
//
//var task = delayedOutput();
//Console.WriteLine($"delayedOutput: {task.Id} - {task.GetType().BaseType.BaseType}");
//
//task.GetAwaiter().GetResult();


ConsoleKeyInfo cki;
Console.Clear();

// Establish an event handler to process key press events.
Console.CancelKeyPress += new ConsoleCancelEventHandler(myHandler);
while (true) {
    Console.Write("Press any key, or 'X' to quit, or ");
    Console.WriteLine("CTRL+C to interrupt the read operation:");

    // Start a console read operation. Do not display the input.
    cki = Console.ReadKey(true);

    // Announce the name of the key that was pressed .
    Console.WriteLine("  Key pressed: {0}\n", cki.Key);

    // Exit if the user pressed the 'X' key.
    if (cki.Key == ConsoleKey.X) break;   
}

static void myHandler(object sender, ConsoleCancelEventArgs args)
{
    Console.WriteLine("\nThe read operation has been interrupted.");

    Console.WriteLine("  Key pressed: {0}", args.SpecialKey);

    Console.WriteLine("  Cancel property: {0}", args.Cancel);

    // Set the Cancel property to true to prevent the process from terminating.
    Console.WriteLine("Setting the Cancel property to true...");
    args.Cancel = true;

    // Announce the new value of the Cancel property.
    Console.WriteLine("  Cancel property: {0}", args.Cancel);
    Console.WriteLine("The read operation will resume...\n");
}
