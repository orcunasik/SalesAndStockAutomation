using SalesAndStockAutomation.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.LoadMyServices();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("BlazorAppApiCors", opt =>
    {
        opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler("/errors");

app.UseCors("BlazorAppApiCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
