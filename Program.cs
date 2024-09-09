using PrivatBank.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddHttpClient<CurrencyService>();

var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.MapControllerRoute("", "{controller=Home}/{action=Index}/{id?}");

app.Run();
