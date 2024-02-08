
using Serilog;

namespace CraftPro_REST_Service {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Configure Swagger/OpenAPI
            // Learn more about configuring Swagger/OpenAPI at <https://aka.ms/aspnetcore/swashbuckle>
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configure Serilog for logging
            builder.Host.UseSerilog((context, configuration) =>
                configuration.ReadFrom.Configuration(context.Configuration));

            var provider = builder.Services.BuildServiceProvider();
            var configuration = provider.GetRequiredService<IConfiguration>();

            // Configure CORS
            builder.Services.AddCors(options => {
                var frontendURL = configuration.GetValue<string>("frontend_url");

                options.AddDefaultPolicy(builder => {
                    builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
