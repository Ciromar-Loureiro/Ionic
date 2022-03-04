using Crivo.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crivo.Code.BLL
{
    class PalograficoBLL
    {
        internal static int PercentilProd(int resultado, int tabela)
        {
            return PalograficoDTO.PercentilProd(resultado, tabela);

        }
    }
}
