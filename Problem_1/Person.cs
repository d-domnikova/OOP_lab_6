using System.Text;

public class Person
{
    private string name;
    public virtual string Name { get { return name; }
        set {
            if (value.Length >= 3) { name = value; }
            else { throw new ArgumentException("Name's length should not be less than 3 symbols.");
            }
        }
    }

    private int age;
    public virtual int Age { get { return age; }
        set {
            if (value > 0) { age = value; }
            else { throw new ArgumentException("Age must be positive.");
            }
        }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string? ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

        return stringBuilder.ToString();
    }
}

class Child : Person
{
     public Child(string name, int age)
        : base(name, age)
    { }
    public override int Age
    {
        get { return base.Age; }
        set
        {
            if (value <= 15) { base.Age = value; }
            else
            {
                throw new ArgumentException("Child's age must be less than 15.");
            }

        }
    }
}
