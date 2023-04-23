using Microsoft.EntityFrameworkCore.Design;

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
        throw new NotImplementedException();
    }
}