using backend_projeto.classes;
using backend_projeto.Interfaces;

namespace backend_projeto;

public class PessoaFisica : Pessoa, IPessoaFisica
{

    public string ?cpf { get; set; }
    public DateTime ?DataNascimento { get; set; }
    
    
    
    
    
    public bool ValidarDataNascimento(DateTime dataNasc)
    {
        throw new NotImplementedException();
    }
}
