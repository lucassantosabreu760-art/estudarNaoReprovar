using System;
using System.ComponentModel.Design;
using System.Globalization;

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
        if (placa != 7);
    }





}


 

// git add
// terceiro commit