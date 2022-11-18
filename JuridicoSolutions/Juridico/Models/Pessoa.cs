using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    class Pessoa
    {
        public int Numero { get; set; }
        public char TipoPessoa { get; set; }//F = fisica, J = juridica
        public int Nome { get; set; }
        public int Endereço { get; set; }
        public int MyProperty { get; set; }

        public List<Pessoa> ListaJuridica()
        {
            return null;
        }
        public List<Pessoa> ListaFisica()
        {
            return null;
        }
    }
}
