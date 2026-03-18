public class CounterService
{
    public int Count { get; private set; }
    public event Action? OnChange;

    public void Increment()
    {
        Count++;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}