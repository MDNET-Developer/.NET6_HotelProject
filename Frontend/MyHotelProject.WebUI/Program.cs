using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProject.WebUI.Models;
using MyHotelProject.WebUI.ValidationRules.StaffValidationRules;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IValidator<AddStaffViewModel>,StaffValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation(x =>
{
    x.AutomaticValidationEnabled = true;
});

//Bunu tanitmaq lazimdir ki,api uzre gelen istekler islesin
builder.Services.AddHttpClient();
builder.Services.AddDbContext<MyContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<MyContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
