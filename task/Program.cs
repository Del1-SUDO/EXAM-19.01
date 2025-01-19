System.Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());

System.Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());

System.Console.Write("Enter third number: ");
int c = int.Parse(Console.ReadLine());

int min=a;
int max=a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

if (a<min) min=a;
if (b<min) min=b;
if (c<min) min=c;

System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел: {a+b+c}");
System.Console.WriteLine($"Самое большое число: {max}");
System.Console.WriteLine($"Самое маленькое число: {min}");