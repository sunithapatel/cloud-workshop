using Microsoft.EntityFrameworkCore;
using ResourcesApi.Models;
using ResourcesApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<ResourceDbContext>(opt =>
        opt.UseInMemoryDatabase("Resource"));
}
else
{
    builder.Services.AddDbContext<ResourceDbContext>(opt =>
        opt.UseSqlServer(builder.Configuration["DatabaseConnectionString"]));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        var context = services.GetRequiredService<ResourceDbContext>();
        DbInitializer.Initialize(context);
    }
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
