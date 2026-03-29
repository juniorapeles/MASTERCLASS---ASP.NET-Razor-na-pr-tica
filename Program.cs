var builder = WebApplication.CreateBuilder(args);
var app = builder.Build(); // adicionando dependência 
builder.Services.AddRazorPages();

app.UseHttpsRedirection();
app.UseStaticFiles(); //necessário para adicionar arquivos staticos

// Auxilia no mapeamento das páginas
app.UseRouting(); 
app.MapRazorPages(); 

app.Run();
