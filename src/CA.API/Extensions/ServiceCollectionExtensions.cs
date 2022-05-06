using System.Reflection;
using Microsoft.OpenApi.Models;

namespace CA.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSwaggerGenerator(this IServiceCollection serviceCollection)
    {

        return serviceCollection.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CA.API",
                    Description = "An ASP.NET Core Web API",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Bouchaib MASSIOUI",
                        Url = new Uri("https://bouchaibmassioui.com/")
                    }
                });

                // Swagger XML Documentation File
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
    }
}