﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
    class Pedido
    {
        public int Numero { get; set; }
        public double ValorPedido { get; set; }//F = fisica, J = juridica
        public string DescricaoPedido { get; set; }

        public double getValorPedidosGlobal()
        {
            return 2;
        }
        public double getQuantidadeGlobal()
        {
            return 2;
        }

    }
}
