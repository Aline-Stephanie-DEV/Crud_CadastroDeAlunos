using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EM.Domain;
public class Aluno : Utilitarios, IEntidade
{
    public Aluno(int matricula, string nome, EnumeradorSexo sexo, DateTime nascimento, Cpf cpf)
    {
        Matricula = matricula;
        Nome = nome;
        Sexo = sexo;
        Nascimento = nascimento;
        CPF = cpf;
    }
    public int Matricula { get; init; }
    public string Nome { get; set; } = string.Empty;
    public EnumeradorSexo Sexo { get; set; }

    [DataType(DataType.Date)]
    public DateTime Nascimento { get; set; }
    public Cpf CPF { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Aluno aluno &&
           Matricula == aluno.Matricula &&
           Nome == aluno.Nome &&
           Nascimento == aluno.Nascimento &&
           Sexo == aluno.Sexo &&
           CPF == aluno.CPF;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Matricula, Nome, Sexo, Nascimento, CPF);
    }
    public override string ToString()
    {
        return "Matricula" + Matricula + "\nNome" + Nome + "\nCPF" + CPF.Valor + "\nSexo" + Sexo + "\nNascimento" + Nascimento;
    }
}