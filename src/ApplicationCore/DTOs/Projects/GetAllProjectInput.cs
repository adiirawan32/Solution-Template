namespace ApplicationCore.DTOs.Projects
{
    public class GetAllProjectInput : PaginatedListRequest
    {
        public string Filter { get; set; }
    }
}
