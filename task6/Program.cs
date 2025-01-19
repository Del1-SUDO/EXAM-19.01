Calculator calc = new Calculator();

System.Console.WriteLine("Введите два числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine();
int add = calc.Add(a, b);
System.Console.WriteLine($"{a} + {b} = " + add);

int Subtract = calc.Subtract(a, b);
System.Console.WriteLine($"{a} - {b} = " + Subtract);

int Multiply = calc.Multiply(a, b);
System.Console.WriteLine($"{a} * {b} = " + Multiply);


class Calculator{
    public int a;
    public int b;

    public int Add(int a, int b){
        return a+b;
    }

    public int Subtract(int a, int b){
        return a-b;
    }

    public int Multiply(int a, int b){
        return a*b;
    }

}