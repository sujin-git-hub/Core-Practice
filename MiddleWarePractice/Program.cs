var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");

/////Middleware Chaining
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("First call\n");
//    next(context);
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Second call\n");
//});

//Custom Middleware  Middleware 2)

builder.Services.AddTransient<IMiddleware>();


app.Run();