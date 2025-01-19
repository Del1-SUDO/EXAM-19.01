System.Console.Write("Enter a positive number: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

int even = 0, odd = 0, sum = 0;

System.Console.WriteLine($"Enter {n} numbers: ");
for (int i=0; i<n; i++) {
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i]%2==0){
        even++;
    }
    else odd++;

    if (arr[i]>=0){
        sum+=arr[i];
    }
}

System.Console.WriteLine($"Количество четных чисел: {even}");
System.Console.WriteLine($"Количество нечетных чисел: {odd}");
System.Console.WriteLine($"Сумма положительных чисел:  {sum}");