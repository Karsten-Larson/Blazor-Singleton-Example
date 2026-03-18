using System.Threading;

public class AtomicCounterService : ICounterService
{
    private int _count;
    public event Action? OnChange;

    public int Count => _count; // Reading a 32-bit int is generally atomic in C#

    public void Increment()
    {
        // This is a single, unbreakable operation at the CPU level
        Interlocked.Increment(ref _count);

        OnChange?.Invoke();
    }

    public void Reset()
    {
        Interlocked.Exchange(ref _count, 0);

        OnChange?.Invoke();
    }
}