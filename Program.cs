var builder = WebApplication.CreateBuilder(args);

// Додати сервіси до контейнера.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Конфігурація HTTP запитів.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Додайте ваш маршрут тут
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}");

app.Run();
