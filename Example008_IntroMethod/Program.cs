int a = new Random().Next(10, 99);
Console.WriteLine(a);
int b = new Random().Next(10, 99);
Console.WriteLine(b);
int c = new Random().Next(10, 99);
Console.WriteLine(c);
int d = new Random().Next(10, 99);
Console.WriteLine(d);
int e = new Random().Next(10, 99);
Console.WriteLine(e);
int f = new Random().Next(10, 99);
Console.WriteLine(f);
int g = new Random().Next(10, 99);
Console.WriteLine(g);
int o = new Random().Next(10, 99);
Console.WriteLine(o);
int p = new Random().Next(10, 99);
Console.WriteLine(p);

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;
if (f>max) max = f;
if (g>max) max = g;
if (o>max) max = o;
if (p>max) max = p;

Console.Write("max = ");
Console.WriteLine(max);