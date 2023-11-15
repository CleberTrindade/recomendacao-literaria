using LiteraryRecommendation.Api.Core.Identity;

namespace LiteraryRecommendation.Books.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddControllers();
            return services;
        }

        public static WebApplication UseApiConfiguration(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthConfiguration();

            app.MapControllers();

            return app;
        }
    }
}
