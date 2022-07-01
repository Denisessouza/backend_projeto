using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_projeto.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(DateTime dataNasc);
    }
}