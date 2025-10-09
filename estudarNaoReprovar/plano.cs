public class Plano
{
    public int _idPlano;
    public string _descricao;
    public double _vlrSugerido;


    public void SetvlrSugerido(double vlrSugerido)
    {
       
        if (vlrSugerido < 0)
        {
            throw new Exception("Valor Invalido");
        }

       
    }



}