using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    class Estado
    {

        public int codigo { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }

        public List<Estado> getTodosEstados()
        {
            return null;
        }

        public Estado getRetornaEstado(int idEstado)
        {
            return null;
        }
    }
}
