namespace Projeto01.Domain.Entities;
public class Empresa
{
    #region Properties
    public Guid Id { get; set; }
    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }
    public string CNPJ { get; set; }
    #endregion

    #region Navigations
    public ICollection<Funcionario> Funcionarios { get; set; }
    #endregion
}
