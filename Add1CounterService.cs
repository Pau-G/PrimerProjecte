namespace PrimerProjecte;

public class Add1CounterService : ICounterService
{
    private int _counter = 0;

    public int getAddIncrement()
    {
        return _counter++;
    }
}