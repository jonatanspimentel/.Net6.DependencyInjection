using DependencyInjection.Repository;
using DependencyInjection.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<IDoSomethingService, DoSomethingService>()
                .AddSingleton<IDoSomethingRepository, DoSomethingRepository>();

var app = builder.Build();

// 1. 
app.MapGet("/DoSomething", () =>
{
    using var serviceScope = app.Services.CreateScope();
    return serviceScope.ServiceProvider
        .GetRequiredService<IDoSomethingService>()
        .DoSomething("Thing");
});

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();


app.MapControllers();


app.Run();
