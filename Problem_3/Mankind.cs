class Mankind
{
    static void Main()
    {
        try {
            string[] input = Console.ReadLine().Split(' ');
            Student student = new Student(input[0], input[1], input[2]);

            input = Console.ReadLine().Split(' ');
            Worker worker = new Worker(input[0], input[1], decimal.Parse(input[2]), int.Parse(input[3]));

            Console.WriteLine("\n{0} \n\n{1}", student, worker);
        } 
        catch (ArgumentException e) { Console.WriteLine(e.Message); 
        }
    }    
}