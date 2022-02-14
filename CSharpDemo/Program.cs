// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");

DateTime dt; // struct
if (DateTime.TryParse("01/01/2017", out dt))
{
    Console.WriteLine($"Old-fashioned parse: {dt}");
}

// variable declaration is an expression, not a statement
if (DateTime.TryParse("02/02/2016", out /*DateTime*/ var dt2))
{
    Console.WriteLine($"New parse: {dt2}");
}

// the scope of dt2 extends outside the if block
Console.WriteLine($"I can use dt2 here: {dt2}");

// what if the parse fails?
int.TryParse("abc", out var i);
Console.WriteLine($"i = {i}"); // default value