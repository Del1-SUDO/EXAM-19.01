Cat cat = new Cat(Console.ReadLine(), int.Parse(Console.ReadLine()) );

cat.Say();
cat.ShowInfo();


class Cat{
    public string Name;
    public int Age;

    public Cat(string Name, int Age){
        this.Name = Name;
        this.Age = Age;
    }

    public void Say(){
        System.Console.WriteLine($"{Name} говорит: Мяу!");
    }

    public void ShowInfo(){
        System.Console.WriteLine("Информация о кошке:");
        System.Console.WriteLine($"Кошка {Name}, возраст: {Age} года");
    }

}