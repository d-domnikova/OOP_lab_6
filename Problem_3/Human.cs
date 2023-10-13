public class Human
{
    private string firstName;
    public string FirstName { get { return firstName; } 
        set { 
            if (value.Length > 3 && char.IsUpper(value[0])) { firstName = value; } else
            {
                if (!char.IsUpper(value[0])) throw new ArgumentException("Expected upper case letter. Argument: firstName");
                if (value.Length <= 3) throw new ArgumentException("Expected length at least 4 symbols. Argument: firstName");
            }
        } 
    }

    private string lastName;
     public string LastName { get { return lastName; } 
        set { 
            if (value.Length > 2 && char.IsUpper(value[0])) { lastName = value; } else
            {
                if (!char.IsUpper(value[0])) throw new ArgumentException("Expected upper case letter. Argument: firstName");
                if (value.Length <= 2) throw new ArgumentException("Expected length at least 3 symbols. Argument: firstName");
            }
        } 
    }

    public Human(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public override string? ToString()
    {
        return $"First Name: {FirstName} \nLast Name: {LastName}";
    }
}

