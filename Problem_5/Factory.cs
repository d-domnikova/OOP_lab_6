public class Factory
{
    public Food foodFactory(string foodName)
    {
        switch (foodName.ToLower())
        {
            case "cram":
                return new Cram();
            case "lembas":
                return new Lembas();
            case "apple":
                return new Apple();
            case "melon":
                return new Melon();
            case "honeycake":
                return new HoneyCake();
            case "mushrooms":
                return new Mushroooms();
            default:
                return new EverythingElse();
        }
    }

    public Mood moodFactory(int pointsOfHappines)
    {
        if (pointsOfHappines < -5)
        {
            return new Angry();
        } else if (pointsOfHappines >=-5 && pointsOfHappines <= 0)
        {
            return new Sad();
        } else if (pointsOfHappines >= 1 && pointsOfHappines <= 15)
        {
            return new Happy();
        } else
        {
            return new JavaScript();
        }
    }
}