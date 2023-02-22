namespace ExceptionMiddleware.ExceptionMiddlewares
{
    public static class ExceptionMiddleware
    {
        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
