using System.Collections.Generic;

namespace OA_Service.DTOs.Response
{
    public class Pagination<T>
    {
        public List<T> Items { get; set; }
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}