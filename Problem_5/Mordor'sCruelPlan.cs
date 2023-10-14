class Workspace
{
    static void Main()
    {
        string line = Console.ReadLine();
        if(line.Length <= 1000) {
            string[] input = line.Split(' ');

            int pointsOfHappiness = 0;
            Factory factory = new Factory();

            if (input.Length>=1 && input.Length <=100)
            {
                for(int i = 0; i < input.Length; i++)
                {
                    string foodName = input[i].ToLower();
                    pointsOfHappiness += factory.foodFactory(foodName).pointsOfHappiness;
                }
                Console.WriteLine("{0}\n{1}", pointsOfHappiness, factory.moodFactory(pointsOfHappiness));
            } else
            { Console.WriteLine("The food count would be in the range [1...100]."); }
        } 
        else { Console.WriteLine("The characters in the input string will be no more than 1000."); }

    }
}