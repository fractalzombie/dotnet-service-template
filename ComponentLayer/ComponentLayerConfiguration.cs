using Microsoft.Extensions.DependencyInjection;
using ComponentLayer.Pagination.ComponentFactory;
using ComponentLayer.Pagination.Services;

namespace ComponentLayer
{
    public static class ComponentLayerConfiguration
    {
        public static void AddComponentLayerContext(this IServiceCollection services)
        {
            services.AddSingleton<IPageRendererFactory, PageRendererFactory>();
            services.AddSingleton<IPageServiceFactory, PageServiceFactory>();
        }
    }
}
