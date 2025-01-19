Piggy pig = new Piggy();

Piggy.Add(int amount);
Piggy.Take(int amount);
Piggy.ShowMoney();

class Piggy{
    public int Money = 0;

    public void Add(int amount){
        System.Console.Write("Сколько вы хотите добавить в копилку: ");
        int n = int.Parse(Console.ReadLine());
        amount += n;
        System.Console.WriteLine($"Добавляем {n} рублей");
    }

    public void Take(int amount){
        System.Console.Write("Сколько вы хотите достать из копилки: ");
        int n = int.Parse(Console.ReadLine());
        amount -= n;
        System.Console.WriteLine($"Достаем {n} рублей");
    }

    public void ShowMoney(){
        System.Console.WriteLine($"В копилке: {amount}");
    }

}