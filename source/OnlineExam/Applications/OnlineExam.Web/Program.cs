using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;
using System.IO;

namespace OnlineExam.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                       .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                       .MinimumLevel.Debug()
                       .Enrich.FromLogContext()
                       .WriteTo.File(Path.Combine("Logs","log - .log"),rollingInterval:RollingInterval.Day)
                       .CreateLogger();
            try
            {
                Log.Information("Application Starting up");
                CreateHostBuilder(args).Build().Run();
            }

            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }

            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
             .UseServiceProviderFactory(new AutofacServiceProviderFactory())
             .UseSerilog()
             .ConfigureWebHostDefaults(webBuilder =>
             {
               webBuilder.UseStartup<Startup>();
             });
    }
}
