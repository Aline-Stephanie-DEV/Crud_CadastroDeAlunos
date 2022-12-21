namespace EM.Domain;
public readonly struct Cpf
{
    public string Valor { get; } 

    public static explicit operator Cpf(string v) => new(cpfValido: v);
    private Cpf(string cpfValido)
    {
        Valor = Utilitarios.CpfASerValidado(cpfValido) ? Convert.ToUInt64(cpfValido).ToString(@"000\.000\.000\-00") : string.Empty;
    }

    public static implicit operator string(Cpf cpf) => cpf.Valor;
    public override string ToString() => Valor;
}