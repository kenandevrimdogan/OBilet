using Microsoft.AspNetCore.Http;
using OBilet.Presentation.UI.Web.Infrastructure;

namespace OBilet.Presentation.UI.Web.Middleware
{
    public class HeaderCheckMiddleware : IMiddleware
    {
        private readonly ICacheService _cacheService;

        public HeaderCheckMiddleware(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }


        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await _cacheService.SetSessionInfoAsync();

            await next.Invoke(context);
        }
    }
}
