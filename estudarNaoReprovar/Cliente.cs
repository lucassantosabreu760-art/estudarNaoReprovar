public class Cliente
{
    string cpf;



    public Cliente(string cpf)
    {
        Validar(cpf);
    }

    public static void Validar(string cpf)
    {
        // 1. Limpa a string: Remove pontos, traços e outros caracteres não-numéricos.
        string cpfLimpo = new string(cpf.Where(char.IsDigit).ToArray());

        // 2. Validações preliminares
        if (cpfLimpo.Length != 11)
        {
            throw new ArgumentException("O CPF deve conter exatamente 11 dígitos numéricos.");
        }

        // Verifica se todos os dígitos são iguais 
        if (cpfLimpo.Distinct().Count() == 1)
        {
            throw new ArgumentException("CPFs com dígitos repetidos (ex: 111.111.111-11) são inválidos.", nameof(cpf));
        }

        
        int[] digitos = cpfLimpo.Select(c => int.Parse(c.ToString())).ToArray();

        // --- CÁLCULO DO 1º DÍGITO VERIFICADOR (DV1) ---

        int soma1 = 0;
        for (int i = 0; i < 9; i++)
        {
            soma1 += digitos[i] * (10 - i);
        }

        int resto1 = soma1 % 11;
        int dv1Calculado = (resto1 < 2) ? 0 : 11 - resto1;

        // 3. Compara o DV1 calculado com o DV1 original
        if (dv1Calculado != digitos[9])
        {
            throw new ArgumentException("Primeiro dígito verificador inválido.", nameof(cpf));
        }

        // --- CÁLCULO DO 2º DÍGITO VERIFICADOR (DV2) ---

        int soma2 = 0;
        for (int i = 0; i < 10; i++)
        {
            soma2 += digitos[i] * (11 - i);
        }

        int resto2 = soma2 % 11;
        int dv2Calculado = (resto2 < 2) ? 0 : 11 - resto2;

        // 4. Compara o DV2 calculado com o DV2 original
        if (dv2Calculado != digitos[10])
        {
            throw new ArgumentException("Segundo dígito verificador inválido.", nameof(cpf));
        }

        // Se o código chegar até aqui, o CPF é VÁLIDO e a função termina sem exceção.
    }
}
