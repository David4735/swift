using swift.Components;
using Blazored.LocalStorage; // Добавляем пространство имён

var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку Blazored LocalStorage
builder.Services.AddBlazoredLocalStorage();

// Добавляем поддержку Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Конфигурация HTTP-пайплайна
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();