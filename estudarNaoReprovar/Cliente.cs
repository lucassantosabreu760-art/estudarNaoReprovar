using System.Globalization;

public class Cliente : Pessoa {

    private string _cpf;
    public string sexo;
  

    public void SetCpf(string cpf)
    {
        validar.Validarcpf(cpf);

    }
    public string Getcpf() 
    {
        return _cpf; 
    }
    
}


