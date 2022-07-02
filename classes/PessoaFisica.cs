using backend_projeto.classes;
using backend_projeto.Interfaces;

namespace backend_projeto;

public class PessoaFisica : Pessoa, IPessoaFisica
{

    public string? cpf { get; set; }
    public DateTime? DataNascimento { get; set; }

    public override float PagarImposto(float rendimento)
    {
        throw new NotImplementedException();
    }

    public bool ValidarDataNascimento(DateTime dataNasc)
    {
        return ValidarDataNascimento(dataNasc, false);
    }

    public bool ValidarDataNascimento(DateTime dataNasc, bool v)
    {

        DateTime dataAtual = DateTime.Today;
        double anos = (dataAtual - dataNasc).TotalDays / 365;
        if (anos >= 18)
            return true;

        else
            return true;

           
            

    }
}
