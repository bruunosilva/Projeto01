using FluentValidation;
using Projeto01.Domain.Entities;
using Projeto01.Validations;

namespace Projeto01.Domain.Validations;
public class FuncionarioValidation : AbstractValidator<Funcionario>
{
    public FuncionarioValidation()
    {
        RuleFor(f => f.Id)
            .NotEmpty().WithMessage("Id do funcionario é obrigatório.");

        RuleFor(f => f.Nome)
            .NotEmpty().WithMessage("Nome é obrigatório.")
            .Length(6, 150).WithMessage("Nome deve ter de 6 a 150 caracteres.");

        RuleFor(f => f.CPF)
            .NotEmpty().WithMessage("CPF é obrigatório.")
            .Length(11).WithMessage("CPF deve ter 11 caracteres.")
            .Must(CpfValidation.IsValid).WithMessage("CPF inválido");

        RuleFor(f => f.Matricula)
            .NotEmpty().WithMessage("Matrícula do funcionário é obrigatório.")
            .Length(6).WithMessage("Matrícula deve ter de 6 a 150 caracteres.");

        RuleFor(f => f.DataAdmissao)
            .NotEmpty().WithMessage("Data de admissão do funcionário é obrigatório.");

        RuleFor(f => f.EmpresaId)
            .NotEmpty().WithMessage("Id da empresa é obrigatório.");
    }
}