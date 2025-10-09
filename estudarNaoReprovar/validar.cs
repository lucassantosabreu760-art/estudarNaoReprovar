public static class validar
{
    public static void Validarcpf(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");
        cpf = cpf.Trim();
        if (cpf.Length != 11)
        {
            throw new Exception("CPF INVALIDO");

        }


        int contador = 10;
        int somaMult = 0;
        for (int i = 0; i < cpf.Length - 2; i++)
        {
            somaMult += int.Parse(cpf[i].ToString()) * contador;
            contador--;
        }

        int mod = somaMult % 11;

        if (mod < 2 && int.Parse(cpf[9].ToString()) != 0)
        {

            throw new Exception("CPF INVALIDO");
        }
        else if (mod >= 2)
        {
            int digValidador = 11 - mod;
            if (int.Parse(cpf[9].ToString()) != digValidador)
            {
                throw new Exception("CPF INVALIDO");
            }
        }
        // verificar 2 digito

        contador = 11;
        somaMult = 0;
        for (int i = 0; i < cpf.Length - 1; i++)
        {
            somaMult += int.Parse(cpf[i].ToString()) * contador;
            contador--;
        }

        mod = somaMult % 11;

        if (mod < 2 && int.Parse(cpf[10].ToString()) != 0)
        {

            throw new Exception("CPF INVALIDO");
        }
        else if (mod >= 2)
        {
            int digValidador = 11 - mod;
            if (int.Parse(cpf[10].ToString()) != digValidador)
            {
                throw new Exception("CPF INVALIDO");
            }
        }
    }

}