public interface ICounterService
{
    int Count { get; }
    event Action? OnChange;
    void Increment();
}