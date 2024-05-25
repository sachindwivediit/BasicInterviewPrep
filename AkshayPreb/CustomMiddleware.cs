
namespace AkshayPreb
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Aksya 1");
            await next(context);
            await context.Response.WriteAsync("verma 1");
        }
    }
}
