using System;
using System.Globalization;

public class Carro
{
    public int id_carro;
    public string modelo;
    public string placa;
    public string renavam;
    public string chassi;

    public Carro(string chassi)
    {
        ValidarChassi(chassi);
        this.chassi = chassi;
    }

    public Carro(string chassi, int id_carro, string placa, string renavam, string modelo)
    {
        ValidarChassi(chassi);
        this.chassi = chassi;
        this.placa = placa;
        this.renavam = renavam;
        this.modelo = modelo;
        this.id_carro = id_carro;
    }

    public void ValidarChassi(string chassi)
    {
        if (chassi.Length == 17 && !chassi.Contains("O") && !chassi.Contains("Q") && !chassi.Contains("I"))
        {
            throw new Exception("Valido");

        }
        else
        {
            throw new Exception("ERRO");
        }
    }










}


 

