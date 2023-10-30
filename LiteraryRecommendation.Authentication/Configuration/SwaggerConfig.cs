using Microsoft.OpenApi.Models;

namespace LiteraryRecommendation.Authentication.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Literary Recommendation Authentication Api",
                    Description = "Essa Api tem o objetivo de Registrar e Autenticar usuários.",
                    Contact = new OpenApiContact() { Name = "Cleber Trindade", Email = "cleber.trindade.net@gmail.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/license/mit/") }
                });
            });
            return services;
        }

        public static WebApplication UseSwaggerConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                });
            }

            return app;
        }
    }
}
