using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using ComponentLayer.Pagination.Data;
using ComponentLayer.Pagination.Exceptions;
using PVG = ComponentLayer.Pagination.Services.PageViewGenerator;

namespace ComponentLayer.Pagination.Services
{
    public class PageService
    {
        public const int MinPageValue = 1;
        private readonly PageData _pageData;
        public int PageCount => _pageData.PageCount;

        public PageService(PageData pageData)
        {
            _pageData = pageData;
        }

        public IEnumerable<PageView> Paginate()
        {
            var pageList = _pageData switch
            {
                {Side: SideType.Neither} pd => PVG.MakePageList(MinPageValue, pd.PageCount - 1),
                {Side: SideType.Unknown} pd => PVG.MakePageList(pd.StartPage, pd.EndPage),
                {Side: SideType.Left} pd => PVG.MakeLeftSidePageList(pd.StartPage, pd.EndPage, pd.SideOffset),
                {Side: SideType.Right} pd => PVG.MakeRightSidePageList(pd.StartPage, pd.EndPage, pd.SideOffset),
                {Side: SideType.Both} pd => PVG.MakeBothSidePageList(pd.StartPage, pd.EndPage),
                _ => throw new IllegalSideTypeStateException(_pageData),
            };

            return PVG.MakeFinalizePageList(pageList, _pageData.PageCount);
        }

        public void OnPageSelect(int selectedPage, EventCallback<int>? currentPageChanged)
        {
            if (_pageData.CurrentPage.Equals(selectedPage)) return;

            currentPageChanged?.InvokeAsync(Math.Clamp(selectedPage, MinPageValue, PageCount));
        }
    }
}
