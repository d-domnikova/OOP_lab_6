class Student : Human
{
    private string facilityNum;
    public string FacilityNum
    {
        get { return facilityNum; }
        set {
            if (value.Length >= 5 && value.Length <= 10) { facilityNum = value; }
            else { throw new ArgumentException("Invalid faculty number."); }
        }
    }

    public Student(string firstName, string lastName, string facilityNum) : base(firstName, lastName)
    {
        this.FacilityNum = facilityNum;
    }

    public override string? ToString()
    {
        return $"{base.ToString()} \nFacility Number: {FacilityNum}";
    }
}

class Worker : Human
{
    private decimal weekSalary;
    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value > 10) { weekSalary = value; }
            else { throw new ArgumentException("Expected value mismatch. Argument: weekSalary"); }
        }
    }
    private int workHoursPerDay;
    public int WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value >= 1 && value <=12) { workHoursPerDay = value; }
            else { throw new ArgumentException("Expected value mismatch. Argument: workHoursPerDay"); }
        }
    }

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
    private decimal salaryPerHour()
    {
        return (WeekSalary/5/workHoursPerDay);
    }

    public override string? ToString()
    {
        return $"{base.ToString()} \nWeek Salary: {WeekSalary.ToString("F")} \nHours Per Day {WorkHoursPerDay} \nSalary Per Day {salaryPerHour().ToString("F")}";
    }
}