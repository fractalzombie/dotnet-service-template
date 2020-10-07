using System;

namespace ComponentLayer.Pagination.Data
{
    public struct PageData
    {
        public int Limit { get; set; }
        public int CurrentPage { get; set; }
        public int ElementsCount { get; set; }
        public int SidePageCount { get; set; }
        public int PageCount => (int) Math.Ceiling((decimal) ElementsCount / Limit);
        private int TotalNumbers => SidePageCount * 2 + 3;
        private int TotalBlocks => TotalNumbers + 2;
        public int StartPage => Math.Max(CurrentPage - SidePageCount, 2) - 1;
        public int EndPage => Math.Min(CurrentPage + SidePageCount, PageCount);

        public int SideOffset => CurrentPage >= PageCount - SidePageCount
            ? TotalNumbers - (EndPage - StartPage) + 1
            : TotalNumbers - (EndPage - StartPage);

        private bool IsPageCountSmallerThanLimitOrEqualsToLimit => PageCount <= TotalBlocks;
        private bool HasLeftSide => StartPage > 1;
        private bool HasRightSide => PageCount - EndPage > 1;

        public SideType Side => this switch
        {
            {IsPageCountSmallerThanLimitOrEqualsToLimit: true} => SideType.Neither,
            {HasLeftSide: true, HasRightSide: false} => SideType.Left,
            {HasLeftSide: false, HasRightSide: true} => SideType.Right,
            {HasLeftSide: true, HasRightSide: true} => SideType.Both,
            _ => SideType.Unknown
        };
    }
}
