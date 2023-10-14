public abstract class Mood{
    public abstract string mood { get; }
}

class Angry : Mood
{ public override string mood => "Angry"; }
class Sad : Mood
{ public override string mood => "Sad"; }

class Happy : Mood
{ public override string mood => "Happy"; }

class JavaScript : Mood
{ public override string mood => "JavaScript"; }
