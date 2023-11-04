namespace PaginationClass.Model
{
    public class PagerResponse<T>
    {
        public T Data { get; set; }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalCount { get; set; }
    }
}
