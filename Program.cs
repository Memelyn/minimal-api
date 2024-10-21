var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/logi", (MinimalAPI.DTOs.LoginDTO loginDTO) => {
    if (loginDTO.Email == "adm@teste" && loginDTO.Senha == "123456"){
        return Results.Ok("Login com sucesso");
    }
     else{
            return Results.Unauthorized();
        }
});

app.Run();

