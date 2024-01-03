// Startup.cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<VideoEditingTaskService>(); // Add your service
    // other configurations...
}
