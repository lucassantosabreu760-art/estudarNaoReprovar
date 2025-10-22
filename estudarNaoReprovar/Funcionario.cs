using System.Security.Cryptography.X509Certificates;

public class Funcionario : Pessoa
{
    private string _cpf;
    public static double mediaSalario;

    public void Setcpf(string cpf)
    {
        validar.Validarcpf(cpf);

    }
    public string Getcpf()
    {
        return _cpf;
    }

}