namespace EM.Domain;
public class Utilitarios
{
    public static bool CpfASerValidado(string? cpf)
    {
        if (cpf is null) { return false; }
        if (cpf.Length != 11)
        {
            return false;

        }

        switch (cpf)
        {
            case "01234567890": return false;
            case "00000000000": return false;
            case "11111111111": return false;
            case "22222222222": return false;
            case "33333333333": return false;
            case "44444444444": return false;
            case "55555555555": return false;
            case "66666666666": return false;
            case "77777777777": return false;
            case "88888888888": return false;
            case "99999999999": return false;
        }

        bool ehValorNumerico = long.TryParse(cpf, out _);
        if (ehValorNumerico == false)
        {
            return false;
        }

        int somaDigitos = 0;
        int multiplicacaoDigitos;
        for (int i = 0; i < 9; i++)
        {
            multiplicacaoDigitos = int.Parse(cpf[i].ToString()) * (i + 1);
            somaDigitos += multiplicacaoDigitos;
        }

        int primeiroDigitoVerificador = somaDigitos % 11;
        if (primeiroDigitoVerificador == 10)
        {
            primeiroDigitoVerificador = 0;
        }
        if (primeiroDigitoVerificador != int.Parse(cpf[9].ToString()))
        {
            return false;
        }

        somaDigitos = 0;
        for (int i = 0; i < 10; i++)
        {
            multiplicacaoDigitos = int.Parse(cpf[i].ToString()) * (i);
            somaDigitos += multiplicacaoDigitos;
        }

        int segundoDigitoVerificador = somaDigitos % 11;
        if (segundoDigitoVerificador == 10)
        {
            segundoDigitoVerificador = 0;
        }
        if (segundoDigitoVerificador != int.Parse(cpf[10].ToString()))
        {
            return false;
        }

        return true;
    }

}