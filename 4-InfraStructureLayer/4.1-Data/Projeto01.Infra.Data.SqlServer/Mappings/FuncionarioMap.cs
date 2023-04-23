using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto01.Domain.Entities;

namespace Projeto01.Infra.Data.SqlServer.Mappings;
public class funcionarioMap : IEntityTypeConfiguration<Funcionario>
{
    public void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        //NOME DA TABELA
        builder.ToTable("FUNCIONARIO");

        //CHAVE PRIMÁRIA
        builder.HasKey(f => f.Id);

        //CAMPOS
        builder.Property(f => f.Id)
            .HasColumnName("IDFUNCIONARIO");

        builder.Property(f => f.Nome)
            .HasColumnName("NOME")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(f => f.CPF)
            .HasColumnName("CPF")
            .HasMaxLength(11)
            .IsRequired();

        builder.Property(f => f.Matricula)
            .HasColumnName("MATRICULA")
            .HasMaxLength(6)
            .IsRequired();

        builder.Property(f => f.DataAdmissao)
            .HasColumnName("DATAADMISSAO")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(f => f.EmpresaId)
            .HasColumnName("IDEMPRESA")
            .IsRequired();

        #region Relacionamentos

        builder.HasOne(f => f.Empresa)//funcionario tem 1 Empresa
            .WithMany(e => e.Funcionarios)//empresa tem muitos Funcionarios
            .HasForeignKey(f => f.EmpresaId);//Chave estrangeira (FK)

        #endregion
    }
}