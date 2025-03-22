abstract class Instrument
{
    public string Name { get; set; }
    public Instrument(string name)
    {
        Name = name;
    }
    public abstract void Play();
}

interface IStringInstrument
{
    void TuneStrings();
}

interface IPercussionInstrument
{
    void Hit();
}

class Guitar : Instrument, IStringInstrument
{
    public Guitar(string name) : base(name) { }
    public override void Play()
    {
        Console.WriteLine($"{Name} играет аккорды.");
    }

    public void TuneStrings()
    {
        Console.WriteLine($"{Name} настраивает струны");
    }
}

class Drum : Instrument, IPercussionInstrument
{
    public Drum(string name) : base(name) { }
    public override void Play()
    {
        Console.WriteLine($"{Name} бьет в барабаны");
    }

    public void Hit()
    {
        Console.WriteLine($"{Name} ударяет по барабану");
    }
}
