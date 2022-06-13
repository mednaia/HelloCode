// Собрать строку с числами от a до b, a<=b.
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i <=b; i++)
    {
        result+=$"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


//Числа от большего к меньшему
string NumbersFor(int a, int b)
{
string result = String.Empty;
for (int i = a; i >= b; i--)
{
result += $"{i} ";
}
return result;
}

string NumbersRec(int a, int b)
{
if (a >= b) return NumbersRec(a - 1, b) + $"{a} ";
else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

//Сумма чисел от 1 до n
int SumFor(int n)
{
int result = 0;
for (int i = 1; i <= n; i++) result += i;
return result;
}

int SumRec(int n)
{
if (n == 0) return 0;
else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55


//Факториал числа
int FactorialFor(int n)
{
int result = 1;
for (int i = 1; i <= n; i++) result *= i;
return result;
}

int FactorialRec(int n)
{
if (n == 1) return 1;//хорошо бы еще описать факториал "0"
else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

//Вычислить а в степени n
int PowerFor(int a, int n)
{ int result = 1;
for (int i = 1; i <= n; i++) result *= a;
return result;
}

int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
if (n == 0) return 1; //0 в степени 0 не рассматривается 
else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024

int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10)); // 1024

//Перебор слов
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++,-5}{s[i]}");
}



char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}
//можно создать метод, ктоорый будет перебирать текст в поисках заданной буквы

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
}
FindWords(“аисв”, new char[5]);

int n =1; //счетчик слов
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords(“аисв”, new char[5]);


//алгоритм обхода директории
string path = "/Users/sergejkamaneckij/Projects/HelloCode/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for(int i = 0; i<fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
 


void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
    Console.WriteLine($"{indent}{item.Name}");
    }
}
string path = @"/Users/sergejkamaneckij/Projects/HelloCode";
CatalogInfo(path);

//Игра в пирамидки
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

//Обход разных структур
//((4 - 2) * (1 + 3)) / 10
//https://ru.wikipedia.org/wiki/%D0%94%D0%B2%D0%BE%D0%B8%D1%87%D0%BD%D0%BE%D0%B5_%D0%B4%D0%B5%D1%80%D0%B5%D0%B2%D0%BE
//https://ru.wikipedia.org/wiki/%D0%9E%D0%B1%D1%85%D0%BE%D0%B4_%D0%B4%D0%B5%D1%80%D0%B5%D0%B2%D0%B0
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                  0   1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
//Variant 2
void PreOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        Console.WriteLine(tree[pos]);
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

//Фибоначчи
decimal fRec = 0;
decimal fIte =0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n==0 || n ==1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result =1;
    decimal f0 =1;
    decimal f1 =1;
    for(int i = 2; i<= n; i++)
    {
        result = f0+f1;
        f0=f1;
        f1=result;
        fIte++;
    }
    return result;
}

Console.ReadLine();
DateTime dt = DateTime.Now;
for(int n = 10; n <40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
DateTime dt = DateTime.Now;
for(int n = 10; n <40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

//Ошибочки
int[,] pic = new int[1000, 1000];
for (int i = 0; i < 1000; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 999] = 1;
    pic[999, i] = 1;
}