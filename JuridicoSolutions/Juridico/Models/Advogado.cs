using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    public class Advogado
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }
        public pais Pais { get; set; }

        public List<Advogado> getTodosAdv()
        {
            return null;
        }

        public string getNomeCompleto()
        {
            return this.nome + " "+ this.sobrenome;
        }

        public Advogado getAdvogadoPorID(int pcodigo)
        {
            return null;
        }

        public List<Advogado> getAdvogadoporPais(int ppais)
        {
            return null;
        }

    }
}
