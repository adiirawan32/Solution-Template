using System.Collections.Generic;

namespace ApplicationCore
{
    public class PaginatedListResponse<T> : Response
    {
        public IList<T> Items { get; set; } = new List<T>();
        public int TotalCount { get; set; }
    }
}
