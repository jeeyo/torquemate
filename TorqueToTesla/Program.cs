using Microsoft.OpenApi.Models;
using Serilog;
using TorqueToTesla.Services;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();

builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddLogging();
builder.Services.AddMemoryCache();
builder.Services.AddControllers();

builder.Services.AddSingleton<IStorageService, StorageService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "TorqueToTesla",
        Description = "A service to receive and store vehicle data from Torque Android App and make it available to be polled as Tesla API",
        Contact = new OpenApiContact
        {
            Name = "GitHub",
            Url = new Uri("https://github.com/jeeyo/torque-to-tesla")
        },
        License = new OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://github.com/jeeyo/torque-to-tesla/blob/main/LICENSE")
        }
    });

    var filePath = Path.Combine(AppContext.BaseDirectory, "TorqueToTesla.xml");
    options.IncludeXmlComments(filePath);
});

builder.Host.UseSerilog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.MapControllers();

app.Run();
