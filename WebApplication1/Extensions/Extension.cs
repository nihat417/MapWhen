using WebApplication1.Extension;

namespace WebApplication1.Extensions
{
    public static class Extension
    {
        public static IApplicationBuilder builder(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MapWhenHakuna>();
        }
    }
}
