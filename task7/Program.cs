System.Console.WriteLine("Название, автор и год издания: ");
Book info = new Book(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()) );

System.Console.WriteLine();
System.Console.WriteLine("Информация о книге:");
info.ShowInfo();

System.Console.WriteLine();
System.Console.Write("Эта книга издана позже 1800 года? ");
bool answer = info.IsNewBook(Year);
if (answer == true){
    System.Console.WriteLine("Да");
}
else if (answer == false){
    System.Console.WriteLine("Нет");
}

class Book {
    public string Title;
    public string Author;
    public int Year;

    public Book(string Title, string Author, int Year){
        this.Title = Title;
        this.Author = Author;
        this.Year = Year;
    }

    public void ShowInfo(){
        System.Console.WriteLine($"Книга: {Title}");
        System.Console.WriteLine($"Автор: {Author}");
        System.Console.WriteLine($"Год издания: {Year}");
    }

    public bool IsNewBook(int Year){
        if (Year>1800){
            return true;
        }
        else{
            return false;
        }
    }
}