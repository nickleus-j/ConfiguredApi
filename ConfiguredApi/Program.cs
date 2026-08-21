using ConfiguredApi.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOptions<ApiSettings>()
    .Bind(builder.Configuration.GetSection("ApiSettings"))
    .ValidateDataAnnotations()
    .ValidateOnStart(); // Throws on startup if validation fails
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();