using MediatR;
using Microsoft.EntityFrameworkCore;
using PhoneBook.BLL.Tags.Commands;
using PhoneBook.DAL.DbContexts;
using PhoneBook.DAL.Tags;
using SimpleShop.DAL.Framework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PhoneBookContext>(c => c.UseSqlServer("Server=.; Initial Catalog=PhoneBook; Integrated Security = SSPI").
    AddInterceptors(new AddAuditFieldInterceptor()));

builder.Services.AddMediatR(
    typeof(CreateTagAppServise).Assembly);


builder.Services.AddScoped<ITagRepository, TagRepository>();


builder.Services.AddControllersWithViews();

builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseMvcWithDefaultRoute();

app.Run();
