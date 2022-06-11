void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}
//DrawText("Intensive C# Demo text", 629, 360);
//Антипаттерн "Магическое число"
// string caption = "Intensive C# Demo text";
// int screenWightPosition = (Console.WindowWight - caption.Length) / 2;
// int screenHeightPosition = Console.WindowHeigth / 2;
// DrawText(caption, screenWightPosition, screenHeightPosition);

// DrawText(
//     text: caption,
//     left: screenWightPosition,
//     top: screenHeightPosition
// );

//Инициализация строк
// string label = "";
// string address = String.Empty; //предпочтительнее

// //Пример 1
// double a=1, b=26, c=120;
// var d = b*b-4*a*c;
// double x1 = (-b+Math.Sqrt(d)) / (2*a);
// double x2 = (-b-Math.Sqrt(d)) / (2*a);
// Console.WriteLine($"x1={x1} x2={x2}");


// //Пример 2
// a=2; b=1; c=-3;
// d = b*b-4*a*c;
// double x1 = (-b+Math.Sqrt(d)) / (2*a);
// double x2 = (-b-Math.Sqrt(d)) / (2*a);
// Console.WriteLine($"x1={x1} x2={x2}");

// //Пример 3
// a=1; b=1; c=-6;
// d = b*b-4*a*c;
// double x1 = (-b+Math.Sqrt(d)) / (2*a);
// double x2 = (-b-Math.Sqrt(d)) / (2*a);
// Console.WriteLine($"x1={x1} x2={x2}");
public Roots Solve(double a, double b, double c)
{
    var d = b*b-4*a*c;
    double x1 = (-b+Math.Sqrt(d)) / (2*a);
    double x2 = (-b-Math.Sqrt(d)) / (2*a);
    return new Roots {X1 = x1, X2 = x2};
}