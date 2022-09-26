using backend_projeto.Interfaces;
using System.Text.RegularExpressions;

namespace backend_projeto.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        
        public string ?razaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <1500)            {
                return(rendimento/100) * 3;

            } else if( rendimento >1500 && rendimento <=3500){
                return (rendimento/100) * 5;

                } else if(rendimento >3500 && rendimento <6000){
                return(rendimento /100) * 7;

            } else {
                return (rendimento/100) * 9;
            }   
        }

        public bool ValidarCnpj(string cnpj)
        {
                if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14}))$")) {

                    if(cnpj.Length==18)
                        if (cnpj.Substring(11,4) =="0001") {
                            return true;

                        } else if (cnpj.Length == 14) {
                            if(cnpj.Substring(8,4)== "0001")
                            return true;
                            
                        }
                    return true;
                }
                
                return false;
                }
                
                    public void Inserir(PessoaJuridica pj)
                    //metodo de inserir dados - RECEBE UM OBJETO
                {
                    VerificarpastaArquivo(caminho);   
                    //Método evocado para que ele antes de tudo, verifique o caminho                 
                    string[] pjString = {$"{pj.nome}, {pj.cnpj}, {pj.razaoSocial}"};
                    //Conversão de String para Array - Método que recebe um Array de strings
                    File.AppendAllLines(caminho, pjString);
                    //Acessar e escrever dentro do arquivo
               }
                
                public List<PessoaJuridica> Ler() {

                    List<PessoaJuridica> listaPj = new List <PessoaJuridica>();
                    //CRIAMOS UMA NOVA LISTA DE PESSOA JURÍDICA
                    string[] linhas = File.ReadAllLines(caminho); 
                    //Leitura do Array de strings
                    foreach(string cadaLinha in linhas) {
                    // FOREACH: leitor de strings e arrays - cada vez que ele lê, armazena na variavel cadaLinha
                    string[] atributos = cadaLinha.Split(",");
                    // atributos é o nome da Array. Agora ele divide, quebra, nas VÍRGULAS.

                    PessoaJuridica cadaPj = new PessoaJuridica();
                    //Criou-se um novo objeto

                    cadaPj.nome = atributos[0];
                    cadaPj.cnpj = atributos[1];
                    cadaPj.razaoSocial = atributos[2];
                    //Chamamos o objeto e indicamos a posição no Array atributos

                    listaPj.Add(cadaPj); //Adicionamos a Lista 

                    }

                    return listaPj;  //O sistema estava dando erro pq precisava do Retorno
                } 

                    

        }
    }
