using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_projeto.Interfaces;

namespace backend_projeto.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        
        public string ?razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string ValidarCnpj)
        {
            throw new NotImplementedException();
        }
    }
}