using System.Collections.Generic;

namespace WebApplication1.ViewModel
{
    public class PaginateVM<T>
    {
        public List<T> Items { get; set; }
        public int ActivePage { get; set; }
        public int PageCount { get; set; }
    }
}
