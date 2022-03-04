using Crivo.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crivo.Code.BLL
{
    class PerfilPaloBLL
    {
        internal static PerfilProdDTO Produtividade(int[] prod)
        {
            int[] prod1 = new int[5];
            prod1 = prod;

            PerfilProdDTO Prod1 =new PerfilProdDTO();
            Prod1 = PaloProdDTO.Produtividade(prod1);

            return Prod1;

        }
    }
}
