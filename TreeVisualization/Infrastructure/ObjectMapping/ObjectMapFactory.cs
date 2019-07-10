using ApplicationCore.Interfaces;
using Autofac;

namespace Infrastructure.ObjectMapping
{
    public class ObjectMapFactory : IObjectMapFactory
    {
        private readonly ILifetimeScope _lifetimeScope;

        public ObjectMapFactory(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public TMap GetMapping<TMap, TSource>(TSource source)
        {
            return _lifetimeScope.Resolve<IObjectMapping<TSource, TMap>>().MapFrom(source);
        }
    }
}
