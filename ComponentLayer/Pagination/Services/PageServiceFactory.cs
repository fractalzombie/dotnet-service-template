using ComponentLayer.Pagination.Data;

namespace ComponentLayer.Pagination.Services
{
    public class PageServiceFactory : IPageServiceFactory
    {
        public PageService CreateInstance(int currentPage, int sidePageCount, int elementsCount, int limit)
        {
            var pageData = new PageData
            {
                Limit = limit,
                CurrentPage = currentPage,
                ElementsCount = elementsCount,
                SidePageCount = sidePageCount,
            };

            return new PageService(pageData);
        }
    }
}
