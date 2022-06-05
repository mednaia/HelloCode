using System.Linq;

// int a = 12;
// var a = 12;
// Console.WriteLine(a.GetType().Name);

var data = new int[]{1,2,3,4}
        .Where(e=> e>0)
        .Select(e=> new{q=e,w=e+1});

System.Console.WriteLine(data.GetType().Name);