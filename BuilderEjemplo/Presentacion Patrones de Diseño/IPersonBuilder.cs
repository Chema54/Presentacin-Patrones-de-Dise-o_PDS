public interface IPersonBuilder<T>
{
    void Reset();
    T Build();
}