
namespace TestApp;
class Program
{
    static void Main(string[] args)
    {
         var names = new []{ "Anil","Ajay","Sanjay","Kishore","Geetanjali","Reshma"};
        // var res = names.Chunk(2);
        var result1 = names.ElementAt(1);
        var result2 = names.ElementAt(^1); 
        // Console.WriteLine("Hello World!");

        // var first = new []{"Anil"};
        //  var second = new []{"Ajay"};
        //   var third = new []{"Sanjay"};
        //   IEnumerable<string> namesList = first.Concat(second).Concat(third);
        //   if(namesList.TryGetNonEnumeratedCount(out var counta))
        //   {

        //   }
        //   var count = namesList.Count();
        //   var result= namesList.OrderBy(x => x);
          var nam= new []{"Anil","Ajay"};
          var ag= new []{20,30};
          IEnumerable<(string name, int Age)> namesage = nam.Zip(ag);
          var youngest = namesage.MinBy(x => x.Age);
          var Oldest = namesage.MaxBy(x => x.Age);
        Func<string> helloworld1 = () => "Hello World";
        var helloworld = () => "Hello World";
        var helloworld2 = string? () => null;

        var rect = new Rectangle(100,20);
        var newrect = rect with { Width = 100 };
    }
}
