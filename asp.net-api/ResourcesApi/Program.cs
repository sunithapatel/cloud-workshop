using Microsoft.EntityFrameworkCore;
using ResourcesApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ResourceDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration["DatabaseConnectionString"]));

if (builder.Environment.IsDevelopment())
{
    /* 
        Uncomment the two lines below and comment out lines 14-15
        if you do not have SQL Server running locally.
    */
    // builder.Services.AddDbContext<ResourceDbContext>(opt =>
    //     opt.UseInMemoryDatabase("Resource"));
    
    // Allow CORS for the local React app to be able to use this API.
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowLocalhost",
                            builder =>
                            {
                                builder.WithOrigins("http://localhost:3000");
                            });
    });
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseCors("AllowLocalhost");
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
