namespace ApplicationCore.Interfaces
{
    public interface IObjectMapping<in TSource, out TMapped>
    {
        TMapped MapFrom(TSource source);
    }
}