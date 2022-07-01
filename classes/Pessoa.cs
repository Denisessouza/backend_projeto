using backend_projeto.Interfaces;

namespace backend_projeto.classes;

public abstract class Pessoa : IPessoa
{
   
   public string ?nome { get; set; }
   public string ?endereço { get; set; }
   public string ?rendimento { get; set; }
   
   
    
   
   
   
    public float PagarImposto(float rendimento)
    {
        throw new NotImplementedException();
    }
}
