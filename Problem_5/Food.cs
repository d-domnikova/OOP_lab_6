public abstract class Food
{
    public abstract int pointsOfHappiness { get; }
}

class Cram : Food
{ public override int pointsOfHappiness => 2; }
class Lembas : Food
{ public override int pointsOfHappiness => 3; }

class Apple : Food
{ public override int pointsOfHappiness => 1; }

class Melon : Food
{ public override int pointsOfHappiness => 1; }

class HoneyCake : Food
{ public override int pointsOfHappiness => 5; }

class Mushroooms : Food
{ public override int pointsOfHappiness => -10; }

class EverythingElse : Food
{ public override int pointsOfHappiness => -1; }

