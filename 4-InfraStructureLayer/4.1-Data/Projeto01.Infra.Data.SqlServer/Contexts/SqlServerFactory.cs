using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Projeto01.Infra.Data.SqlServer.Contexts;
public class SqlServerFactory : IDesignTimeDbContextFactory<SqlServerContext>
/*
    *Classe para executar o Migrations, incializando a classe
    *SqlServerContext com os parametros de conexão do banco de dados
*/
{
    /*
    Método utilizado pelo Migrations para inicializar a classe
    SqlServerContext utilizando osatributos do appsettings.json
    */
    public SqlServerContext CreateDbContext(string[] args)
    {
        //lendo o arquivo appsettings.json
        var configurationBuilder = new ConfigurationBuilder();
        var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
        configurationBuilder.AddJsonFile(path, false);

        //captura a connectionstring mapeada dentro do arquivo
        var root = configurationBuilder.Build();
        var connectionstring = root.GetSection("ConnectionStrings").GetSection("Projeto01").Value;

        //instanciar a classe SqlServerContext
        var builder = new DbContextOptionsBuilder<SqlServerContext>();
        builder.UseSqlServer(connectionstring);

        return new SqlServerContext(builder.Options);
    }
}