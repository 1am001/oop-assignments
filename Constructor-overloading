using System;

class Book
{
    public string title;
    public string author;
    public string isbn;
    public double price ;

    public Book ()
    {
        title = "Unknown";
        author = "Unknown";
        isbn = "Unknown";
        price = 0.00;
    }
    public Book (string _title, string _author)
    {
        title = _title;
        author = _author;
        isbn = "Unknown";
        price = 0.00;
    }
    public Book (string _title, string _author, string _isbn)
    {
        title = _title;
        author = _author;
        isbn = _isbn;
        price = 0.00;
    }
    public Book (string _title, string _author, string _isbn, double _price)
    {
        title = _title;
        author = _author;
        isbn = _isbn;
        price = _price;
    }

    public void Print ()
    {
        Console.WriteLine("Book's name: " + title );
        Console.WriteLine("Book's author: " + author );
        Console.WriteLine("Book's price: " + price + " $" );
        Console.WriteLine("ISBN no: " + isbn );
        Console.WriteLine("\n");
    }


}

class Program
{
    static void Main ()
    {
        Book book1 = new Book ();
        book1.Print();

        Book book2 = new Book ("A story of Yesterday","Sergio Cobo");
        book2.Print();

        Book book3 = new Book ("To kill a Mockingbird","Harper Lee","200899756");
        book3.Print();

        Book book4 = new Book ("The Elephant Tree","R.D. Ronald","23568419",500);
        book4.Print();

    }
}
