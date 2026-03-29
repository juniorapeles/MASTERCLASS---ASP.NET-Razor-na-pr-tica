var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();


var app = builder.Build(); // adicionando dependência 

app.UseHttpsRedirection();
app.UseStaticFiles(); //necessário para adicionar arquivos staticos



// Auxilia no mapeamento das páginas
app.UseRouting(); 
app.MapRazorPages(); 

app.Run();
