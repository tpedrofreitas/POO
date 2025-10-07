using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ValidaçãoCPF
{
    internal interface IDocumento
    {
        string ObterNumero();
        bool Validar();          
    }
}

