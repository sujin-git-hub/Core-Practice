
namespace MiddleWarePractice.CustomMiddleware
{
    public class MyCustomMiddWare : IMiddleware
    {
        async Task IMiddleware.InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My Custom Middleware - Starts\n");
            await next(context);
            await context.Response.WriteAsync("My Custom Middleware - Ends\n");
        }
    }
}
