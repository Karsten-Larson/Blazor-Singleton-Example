public class CounterService : ICounterService
{
    public int Count { get; private set; }
    public event Action? OnChange;

    public void Increment()
    {
        Count++;
        NotifyStateChanged();
    }

    public void Reset()
    {
        Count = 0;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}