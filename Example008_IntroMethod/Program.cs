int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}


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

int max1 = Max(a,b,c);
int max2 = Max(d,e,f);
int max3 = Max(g,o,p);
int max = Max(max1,max2,max3);

Console.Write("max = ");
Console.WriteLine(max);