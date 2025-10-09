using System.Globalization;

public class Cliente {

    public string _nome;
    private string _cpf;
    public int _idCliente;
    public string sexo;
    public DateOnly _dataNascimento;

    public void SetCpf(string cpf)
    {
        validar.Validarcpf(cpf);

    }
    public string Getcpf() 
    {
        return _cpf; 
    }
    
}


