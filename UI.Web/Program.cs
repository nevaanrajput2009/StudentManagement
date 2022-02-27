using BusinessManager;
using BusinessManager.Interface;

var builder = WebApplication.CreateBuilder(args);
ConfigureServices(builder.Services);

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");
app.Run();


static void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
    services.AddDistributedMemoryCache();
    services.AddSession(options => options.IdleTimeout = TimeSpan.FromMinutes(10));
    services.AddSingleton<IUserService, UserService>();
}