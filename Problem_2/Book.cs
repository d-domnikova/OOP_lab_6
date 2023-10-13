using System.Text;

public class Book
{
    private string author;
    public string Author { get { return author; }
        set {
            if (!value.Any(c => char.IsDigit(c))) { author = value; } 
            else {
                throw new ArgumentException("Author not valid.");
            } 
        }
    }

    private string title;
    public string Title { get { return title; } 
        set { 
            if (value.Length > 3) { title = value; } 
            else {
                throw new ArgumentException("Title not valid.");
            }
        } 
    }
  
    private double price;
    public virtual double Price { get { return price; }
        set {
            if (value > 0) { price = value; }
            else {
                throw new ArgumentException("Price not valid.");
            }
        }
    }

    public Book(string author, string title, double price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public override string? ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
        .AppendLine($"Title: {this.Title}")
        .AppendLine($"Author: {this.Author}")
        .AppendLine($"Price: {this.Price:f2}");
        string result = resultBuilder.ToString().TrimEnd();

        return result;
    }
}

public class GoldenEditionBook : Book {
    public GoldenEditionBook(string author, string title, double price)
    : base(author, title, price) { }
    public override double Price
    {
        get { return base.Price * 1.3; }
    }
}

