System.Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());

System.Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine();
PrintNumber(a, b);
System.Console.WriteLine("Сумма чисел: " + Sum(a, b));
System.Console.WriteLine("Максимальное число: " + Max(a, b));

void PrintNumber(int a, int b){
    if (a%2==0){
        System.Console.WriteLine($"Число {a} является четным");
    }
    if (b%2==0){
        System.Console.WriteLine($"Число {b} является четным");
    }
    if (a%2==1){
        System.Console.WriteLine($"Число {a} является нечетным");
    }
    if (b%2==1){
        System.Console.WriteLine($"Число {b} является нечетным");
    }
}

int Sum(int a, int b){
    return a+b;
}

int Max(int a, int b){
    if (a>=b){
        return a;
    }
    else{
        return b;
    }
}