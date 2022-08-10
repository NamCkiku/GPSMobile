using System.Collections.Generic;

namespace BA_Mobile.Service.Utilities
{
    public interface IMapper
    {
        TDestination MapProperties<TDestination>(object mapSource)
            where TDestination : class, new();

        List<TDestination> MapListProperties<TDestination>(object sources)
          where TDestination : class, new();
    }
}