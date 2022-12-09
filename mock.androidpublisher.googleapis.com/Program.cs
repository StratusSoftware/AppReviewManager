using Microsoft.Extensions.Configuration;
using mock.androidpublisher.googleapis.com.Data.Interfaces;
using mock.androidpublisher.googleapis.com.Data;
using mock.androidpublisher.googleapis.com.Services;
using Microsoft.EntityFrameworkCore;
using AppReview.Shared.Models.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var filePath = Path.Combine(System.AppContext.BaseDirectory, "mock.androidpublisher.googleapis.com.xml");
    c.IncludeXmlComments(filePath);
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseInMemoryDatabase("mockgoogleapi"));

builder.Services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
builder.Services.AddScoped<SeedHelper>();
builder.Services.AddScoped<IReviewService, ReviewService>();

var app = builder
    .Build()
    .SeedData();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
