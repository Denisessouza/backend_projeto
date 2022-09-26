using backend_projeto.Interfaces;

namespace backend_projeto.classes;

public abstract class Pessoa : IPessoa
{
   
   public string ?nome { get; set; }
   public Endereco ?endereço { get; set; }
   public float rendimento { get; set; }
   
   
   
   
   
    public abstract float PagarImposto(float rendimento);

    public void VerificarpastaArquivo(string caminho){
        string pasta = caminho.Split("/")[0];

        if(!Directory.Exists(pasta)) {
            Directory.CreateDirectory(pasta);
        }

        if (!File.Exists(caminho)){

            using ( File.Create(caminho))
            {
                
            }
           
        }

    }   

    
   
}

