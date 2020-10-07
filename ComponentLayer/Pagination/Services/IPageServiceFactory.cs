namespace ComponentLayer.Pagination.Services
{
    public interface IPageServiceFactory
    {
        PageService CreateInstance(int currentPage, int sidePageCount, int elementsCount, int limit);
    }
}
