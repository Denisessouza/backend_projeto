using backend_projeto.classes;
using backend_projeto.Interfaces;

namespace backend_projeto;

public class PessoaFisica : Pessoa, IPessoaFisica
{

    public string? cpf { get; set; }
    public string? DataNascimento { get; set; }

    public override float PagarImposto(float rendimento)
    {
        throw new NotImplementedException();
    }

    

    public bool ValidarDataNascimento(DateTime dataNasc)
    {
        DateTime dataAtual = DateTime.Today;
        double anos = (dataAtual - dataNasc).TotalDays /365;        
        Console.WriteLine($"{anos}");   
        if (anos >= 18)     
        return true;

        else

        return false;

    }

    public bool ValidarDataNascimento(string dataNasc)
    {
        DateTime dataConvertida;
        if (DateTime.TryParse (dataNasc, out dataConvertida)) {
        Console.WriteLine($"{dataConvertida}");
}
        DateTime dataAtual = DateTime.Today;
        double anos = (dataAtual - dataConvertida).TotalDays / 365;

        if (anos >= 18)
            return true;
    
        else 

        return false;
    }
    }

      

    



