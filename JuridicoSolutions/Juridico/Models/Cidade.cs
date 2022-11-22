using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    class Cidade
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public Estado estado { get; set; }

        public List<Cidade> getTodosCidades()
        {
            return null;
        }

        public Cidade getRetornaCidade(int idCidade)
        {
            return null;
        }

        public List<Cidade> getCidadeporEstado(Estado estado)
        {
            return null;
        }
    }
}
