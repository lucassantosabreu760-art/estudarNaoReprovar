using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text.RegularExpressions;

public class Carro
{
    public int id_carro;
    public string modelo;
    public string placa;
    public string renavam;
    private string chassi;

    public Carro(string chassi)
    {
        setchassi(chassi);
        this.chassi = chassi;
        
    }

    public Carro(string chassi, int id_carro, string placa, string renavam, string modelo)
    {
        setchassi(chassi);
        this.chassi = chassi;
        this.placa = placa;
        setplaca(placa);
        this.renavam = renavam;
        this.modelo = modelo;
        this.id_carro = id_carro;
    }


    public void setchassi(string chassi)
    {
        chassi = chassi.ToUpper();
        if (chassi.Length != 17 || chassi.Contains("O") || chassi.Contains("Q") || chassi.Contains("I")) 
        { 
        throw new Exception("Chassi Ivalido");
        }
        chassi = chassi;

    }

    public void setplaca(string placa)
    {
        placa = placa.ToUpper();

        if (Char.IsLetter(placa[0]) && Char.IsLetter(placa[1]) && Char.IsLetter(placa[2]) && Char.IsNumber(placa[3]) && (Char.IsNumber(placa[4]) || Char.IsLetter(placa[4])) && Char.IsNumber(placa[5]) && Char.IsNumber(placa[6]))
        {
            // A placa é válida e atende a um dos padrões.
        }
        else
        {
            // A placa é inválida.
            throw new Exception("PLACA INVÁLIDA. Formatos esperados: ABC-1234 (antiga) ou ABC1D23 (Mercosul).");
            {
            
        
        }
        
        }

        placa = placa;
    }


    


}


 

// git add
// terceiro commit