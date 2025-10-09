using System.Security.Cryptography.X509Certificates;

public class Funcionario
{
    private string _cpf;
    public string _email;
    public string _nome;
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