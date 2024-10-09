using minimal_api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Vamo dominar o mundo porra!!!");

app.MapPost("/login", (LoginDTO loginDTO) =>{
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456"){
        return Results.Ok("Login efetuado com sucesso!");
    }
    else{
        return Results.Unauthorized();
    }
});


app.Run();




