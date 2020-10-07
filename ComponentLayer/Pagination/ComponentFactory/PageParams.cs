using System;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public struct PageParams
    {
        public int CurrentPage { get; set; }
        public int PageNumber { get; set; }
        public int MinPageValue { get; set; }
        public int MaxPageValue { get; set; }
        public Action<int> OnPageSelect { get; set; }
    }
}
