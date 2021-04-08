using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Core.Middlewares
{
    public static class GlobalHandlerException
    {
        public static void UseGlobalHandlerException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";
                    var exception =
                        context.Features.Get<IExceptionHandlerFeature>();
                    await context.Response.WriteAsync(exception.Error.Message);
                });
            });    
        }
    }
}