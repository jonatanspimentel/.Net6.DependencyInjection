// See https://aka.ms/new-console-template for more information
using DependencyInjection.Implementation;
using DependencyInjection.Repository;
using DependencyInjection.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddSingleton<IDoSomethingService, DoSomethingService>()
                .AddSingleton<IDoSomethingRepository, DoSomethingRepository>()
                .AddTransient<DoSomethingWorker>())
    .Build();

ExemplifyScoping(host.Services, "Thing");
await host.RunAsync();

static void ExemplifyScoping(IServiceProvider services, string thing)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    var thingReturned = provider.GetRequiredService<DoSomethingWorker>().DoSomething(thing);

    Console.WriteLine(thingReturned);
}