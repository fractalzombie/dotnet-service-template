using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using ComponentLayer.Pagination.Data;

namespace ComponentLayer.Pagination.Services
{
    internal class PageViewGenerator
    {
        public static IEnumerable<PageView> MakeFinalizePageList(IEnumerable<PageView> pageList, int pageCount) =>
            Enumerable.Empty<PageView>()
                .Union(new List<PageView> {PageView.MakeFirst()})
                .Union(pageList)
                .Union(new List<PageView> {PageView.MakeLast(pageCount)})
                .ToImmutableList();

        public static IEnumerable<PageView> MakeLeftSidePageList(int startPage, int endPage, int sideOffset) =>
            Enumerable.Empty<PageView>()
                .Concat(PageView.MakeLeftSide())
                .Concat(MakePageList(startPage - sideOffset, startPage))
                .Concat(MakePageList(startPage, endPage));

        public static IEnumerable<PageView> MakeRightSidePageList(int startPage, int endPage, int sideOffset) =>
            Enumerable.Empty<PageView>()
                .Concat(MakePageList(startPage, endPage))
                .Concat(MakePageList(endPage, endPage + sideOffset))
                .Concat(PageView.MakeRightSide());

        public static IEnumerable<PageView> MakeBothSidePageList(int startPage, int endPage) =>
            Enumerable.Empty<PageView>()
                .Concat(PageView.MakeLeftSide())
                .Concat(MakePageList(startPage, endPage))
                .Concat(PageView.MakeRightSide());

        public static IEnumerable<PageView> MakePageList(int fromPage, int toPage, PageType pageType = PageType.Page) =>
            Enumerable.Range(fromPage, toPage - fromPage)
                .Select(p => new PageView(p + 1, pageType));
    }
}
