using AutoMapper;

namespace ApplicationCore
{
    public static class PaginatedListExtensions
    {
        public static PaginatedListResponse<T> ToPaginatedListResponse<T>(this PaginatedList<T> source)
        {
            var mapperConfig = new MapperConfiguration(configuration => configuration.CreateMap<PaginatedList<T>, PaginatedListResponse<T>>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<PaginatedList<T>, PaginatedListResponse<T>>(source);
        }
    }
}
