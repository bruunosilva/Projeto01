namespace Projeto01.Domain.Entities;

public class Funcionario
{
    #region Properties
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Matricula { get; set; }
    public string DataAdmissao { get; set; }
    public Guid EmpresaId { get; set; }
    #endregion

    #region Navigations
    public Empresa Empresa { get; set; }
    #endregion
}
