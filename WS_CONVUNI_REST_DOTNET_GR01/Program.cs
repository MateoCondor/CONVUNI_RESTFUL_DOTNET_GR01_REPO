using WS_CONVUNI_REST_DOTNET_GR01.Enums;
using WS_CONVUNI_REST_DOTNET_GR01.Interfaces;
using WS_CONVUNI_REST_DOTNET_GR01.Models;
using WS_CONVUNI_REST_DOTNET_GR01.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("FrontendDev", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<IUnitConverter<MassUnit>, MassConverter>();
builder.Services.AddScoped<IUnitConverter<LengthUnit>, LengthConverter>();
builder.Services.AddScoped<IUnitConverter<TemperatureUnit>, TemperatureConverter>();
builder.Services.AddScoped<UnitConversionService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("FrontendDev");
app.MapControllers();
app.Run();
