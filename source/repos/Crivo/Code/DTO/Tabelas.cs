using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crivo.Code.DTO
{

    //desisti desta classe
    public class Tabelas
    {
        public Tabelas()
        {
        }

        public int[,] CriaTabalaProd(int tab)
        {
            int[,] tabela = new int[2, 15];

            try
            {
                /*
                 * A intenção é criar um array com todas as tabelas de produtividade
                 * que dão 36 tabelas e, de acordo com a escolhida devolver um array com
                 * apenas dois componentes
                 */

                /*Criar o array com todas os dados da tabela
                 * * 0 - Tab 167 - Produtividade - Tabela Geral - Amostra Total
                 * 1 - Tab 168 - Produtividade - Tabela Geral - Sexo Feminino
                 * 2 - Tab 169 - Produtividade - Tabela Geral - Sexo Masculino
                 * 3 - Tab 170 - Produtividade - Tabela Geral - Ens. Fundamental
                 * 4 - Tab 171 - Produtividade - Tabela Geral - Ens. Médio
                 * 5 - Tab 172 - Produtividade - Tabela Geral - Ens. Superior
                 * 6 - Tab 85 - Produtividade - Sudeste - Amostra Total
                 * 7 - Tab 86 - Produtividade - Sudeste - Sexo Feminino
                 * 8 - Tab 87 - Produtividade - Sudeste - Sexo Masculino
                 * 9 - Tab 88 - Produtividade - Sudeste - Ens. Fundamental
                 * 10 - Tab 89 - Produtividade - Sudeste - Ens. Médio
                 * 11 - Tab 90 - Produtividade - Sudeste - Ens. Superior
                 ** 12 - Tab 126 - Produtividade - Sul - Amostra Total
                 * 13 - Tab 127 - Produtividade - Sul - Sexo Feminino
                 * 14 - Tab 128 - Produtividade - Sul - Sexo Masculino
                 * 15 - Tab 129 - Produtividade - Sul - Ens. Fundamental
                 * 16 - Tab 130 - Produtividade - Sul - Ens. Médio
                 * 17 - Tab 131 - Produtividade - Sul - Ens. Superior
                 * * 18 - Tab 146 - Produtividade - Norte - Amostra Total
                 * 19 - Tab 147 - Produtividade - Norte - Sexo Feminino
                 * 20 - Tab 148 - Produtividade - Norte - Sexo Masculino
                 * 21 - Tab 149 - Produtividade - Norte - Ens. Fundamental
                 * 22 - Tab 150 - Produtividade - Norte - Ens. Médio
                 * 23 - Tab 151 - Produtividade - Norte - Ens. Superior
                 * * 24 - Tab 167 - Produtividade - Centro-Oeste - Amostra Total
                 * 25 - Tab 168 - Produtividade - Centro-Oeste - Sexo Feminino
                 * 26 - Tab 169 - Produtividade - Centro-Oeste - Sexo Masculino
                 * 27 - Tab 170 - Produtividade - Centro-Oeste - Ens. Fundamental
                 * 28 - Tab 171 - Produtividade - Centro-Oeste - Ens. Médio
                 * 29 - Tab 172 - Produtividade - Centro-Oeste - Ens. Superior
                 * * 30 - Tab 106 - Produtividade - Nordeste - Amostra Total
                 * 31 - Tab 107 - Produtividade - Nordeste - Sexo Feminino
                 * 32 - Tab 108 - Produtividade - Nordeste - Sexo Masculino
                 * 33 - Tab 109 - Produtividade - Nordeste - Ens. Fundamental
                 * 34 - Tab 110 - Produtividade - Nordeste - Ens. Médio
                 * 35 - Tab 111 - Produtividade - Nordeste - Ens. Superior                 
                 */

                int[] tabPercentil = new int[15] { 1, 5, 10, 20, 25, 30, 40, 50, 60, 70, 75, 80, 90, 95, 99 };
                int[] tabProd = new int[15];
               



                return tabela;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: " + ex);
            }

            return tabela;
        }


        //Tab 91 - NOR - Sudeste - Ens.Fundamental
        //            Tab 91 - NOR - Sudeste - Ens.Médio
        //            Tab 91 - NOR - Sudeste - Ens.Superior
        //            Tab 91 - NOR - Sudeste - Amostra Total
        //            Tab 92 - NOR - Sudeste - Sexo Feminino
        //            Tab 92 - NOR - Sudeste - Sexo Masculino
    }
}
