using Microsoft.OpenApi.Models;
using Serilog;
using TorqueToToe.Services;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();

builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddLogging();
builder.Services.AddControllers();
builder.Services.AddNpgsqlDataSource(builder.Configuration.GetConnectionString("NpgsqlTorqueDatabase") ?? "");
builder.Services.AddHttpContextAccessor();

builder.Services.AddSingleton<ITorqueStorageService, TorqueStorageService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "TorqueToToe",
        Description = "A service to receive and store vehicle data from Torque Android App in database.",
        Contact = new OpenApiContact
        {
            Name = "GitHub",
            Url = new Uri("https://github.com/jeeyo/torque-to-toe")
        },
        License = new OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://github.com/jeeyo/torque-to-toe/blob/main/LICENSE")
        }
    });

    var filePath = Path.Combine(AppContext.BaseDirectory, "TorqueToToe.xml");
    options.IncludeXmlComments(filePath);
});

builder.Host.UseSerilog();

var app = builder.Build();

app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
