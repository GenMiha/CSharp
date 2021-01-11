namespace ServiceLibrary
{
    public interface IParser
    {
        T GetOptions<T>();
    }
}