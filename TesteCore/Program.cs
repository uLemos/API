using TesteCore.Mappings;
using TesteCore.Rest;
using TesteCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISendTextService, SendTextServices>();
//builder.Services.AddSingleton<ISendLinkService, SendLinkServices>();
builder.Services.AddSingleton<IZapiApi, ZapiApiRest>();

builder.Services.AddAutoMapper(typeof(SendTextMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
