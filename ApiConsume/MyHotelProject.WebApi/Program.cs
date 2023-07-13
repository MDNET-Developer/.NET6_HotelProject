using AutoMapper;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.BusinessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.EntityFramework;
using MyHotelProject.DataAccessLayer.Repositories;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProject.WebApi.Extension;
using MyHotelProject.WebApi.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

/*Custom extension method*/
builder.Services.CustomService();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfile(new MappingConfugiration());
});
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("MDPolicy", options =>
    {
        options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MDPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
