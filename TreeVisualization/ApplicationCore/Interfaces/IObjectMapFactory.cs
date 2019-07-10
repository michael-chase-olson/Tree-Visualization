using System.Diagnostics;

namespace ApplicationCore.Interfaces
{
    public interface IObjectMapFactory
    {
        TMap GetMapping<TMap, TSource>(TSource source);
    }
}