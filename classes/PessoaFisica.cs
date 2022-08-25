using backend_projeto.classes;
using backend_projeto.Interfaces;

namespace backend_projeto;

public class PessoaFisica : Pessoa, IPessoaFisica
{

    public string? cpf { get; set; }
    public string? DataNascimento { get; set; }

    public override float PagarImposto(float rendimento)
   
    {
        /*Tabela Imposto:
        ate 1500 (considerando 1500) - isento
        De 1500 a 3500 (considerando 3500) - 2% impostos
        De 3500 a 6000 (considerando 6000) - 3,5% impostos
        Acima de 6000 -  5% impostos*/

        if (rendimento <=1500){
            return 0;

        } else if (rendimento >1500 && rendimento <=3500){
            return (rendimento /100) * 2;

        } else if (rendimento >3500 && rendimento <=6000){
            return (rendimento/100) * 3.5f;
            
        } else (rendimento >6000){
            return(rendimento/100)* 5;
        }
          
    
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

      

    



