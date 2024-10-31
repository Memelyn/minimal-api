using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MinimalAPI.Dominio.Entidades;
using MinimalAPI.Infraestrutura.Db;

namespace Test.Dominio.Entidades;

[TestClass]
public class AdministradorServicoTest
{
     private DbContexto CriarContextoDeTeste(){ 
       var builder = new ConfigurationBuilder()
       .SetBasePath (Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", optional : false, reloadOnChange: true)
       .AddEnvironmentVariables();

      var configuration = builder.Build();

       return new DbContexto(configuration);
        }
    
     [TestMethod]
    public void TestandoSalvarAdministrador()
    {
       
   
        //arrange
        var adm = new Administrador();
        adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        //act
        
    var context = new CriarContextoDeTeste();
        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}