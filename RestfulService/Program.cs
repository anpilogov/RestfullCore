using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RestfulService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()               // настраиваем веб-сервер Kestrel 
                .UseContentRoot(Directory.GetCurrentDirectory())    // настраиваем корневой каталог приложения
                .UseIISIntegration()        // обеспечиваем интеграцию с IIS
                .UseStartup<Startup>()    // устанавливаем главный файл приложения
                .Build();                   // создаем хост
            host.Run();                     // запускаем приложение
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
