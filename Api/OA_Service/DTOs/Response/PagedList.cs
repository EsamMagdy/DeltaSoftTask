using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OA_Service.DTOs.Response
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PageSize = pageSize;
            TotalCount = count;
            AddRange(items);
        }

        public static async Task<Pagination<T>> CreateAsync(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            if (items == null) throw new Exception("Not Found");

            var result = new PagedList<T>(items, count, pageNumber, pageSize);

            return new Pagination<T>()
            {
                Items = result,
                TotalPages = result.TotalPages,
                TotalItems = result.TotalCount,
                ItemsPerPage = result.PageSize,
                CurrentPage = result.CurrentPage
            };
        }
    }
}