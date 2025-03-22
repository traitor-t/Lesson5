class Program
{
    static void Main(string[] args)
    {
        Instrument[] instruments = new Instrument[]
        {
            new Guitar("Гитара"),
            new Drum("Барабан"),
            new Guitar("Классическая гитара"),
            new Drum("Ударные"),
        };
        List<IStringInstrument> stringInstruments = new List<IStringInstrument>();
        foreach (Instrument instrument in instruments)
        {
            if (instrument is IStringInstrument stringInstrument)
            {
                stringInstruments.Add(stringInstrument);
            }
        }
        Console.WriteLine("Найденные струнные инструменты:");
        foreach (var stringInstument in stringInstruments)
        {
            if (stringInstument is Instrument instrument)
            {
                Console.WriteLine(instrument.Name);
            }
        } 
    }
}