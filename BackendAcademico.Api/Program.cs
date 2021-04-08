namespace BackendAcademico.Api
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Serilog;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                //.WriteTo.RollingFile(new JsonFormatter(renderMessage: true),@"C:\Logs\log-{Date}.json")
                .CreateLogger();

            try
            {
                Log.Information("Iniciando procesos de Backend");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception err)
            {
                Log.Fatal(err, "No es posible iniciar el servicio de Backend");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
