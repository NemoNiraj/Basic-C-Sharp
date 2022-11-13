// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// int a = 20;
// float b = 12.2f;

string line = "nirajchavan@gmail.com";

Console.WriteLine(line.Substring(11));

static void Greet()
{
    Console.WriteLine("hello World");
}


//Method Overloading
static float Average(int a, int b, int c)
{
    float sum = a + b + c;
    return sum / 3;
}

static float Average(int a, int b)
{

    return (a + b) / 2;
}

Greet();
Console.WriteLine(Average(3, 3, 3));
Console.WriteLine(Average(4, 4));
Console.ReadLine();
