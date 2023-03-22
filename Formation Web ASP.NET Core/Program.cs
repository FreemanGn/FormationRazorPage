using Formation_Web_ASP.NET_Core.Repositories;
using Formation_Web_ASP.NET_Core.Repository;
using Formation_Web_ASP.NET_Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


//Injection du repository

builder.Services.AddSingleton<IRestaurantRepository,RestaurantRepository>();

//Injection du service 

builder.Services.AddSingleton<IRestaurantService,RestaurantService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
