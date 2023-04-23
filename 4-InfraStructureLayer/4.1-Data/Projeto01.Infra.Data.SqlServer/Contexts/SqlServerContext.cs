using Microsoft.EntityFrameworkCore;
using Projeto01.Domain.Entities;
using Projeto01.Infra.Data.SqlServer.Mappings;

namespace Projeto01.Infra.Data.SqlServer.Contexts;
public class SqlServerContext : DbContext
{
    public SqlServerContext(DbContextOptions<SqlServerContext> options)
        : base(options)
    {

    }

    //DbSet -> provedor para cada entidade (repositorio)
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

    //sobrescrita de métodos (OVERRIDE)

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region  Fluent Mappings

        modelBuilder.ApplyConfiguration(new EmpresaMap());
        modelBuilder.ApplyConfiguration(new funcionarioMap());

        #endregion

        #region Indexes

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasIndex(e => e.CNPJ).IsUnique();
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasIndex(f => f.CPF).IsUnique();
            entity.HasIndex(f => f.Matricula).IsUnique();
        });
        #endregion
    }
}