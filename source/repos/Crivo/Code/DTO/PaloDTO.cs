using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crivo.Code.DTO
{
    public class PaloDTO
    {
        //Produtividade
        private int prodTotal;
        private int prodPercentil;
        private string prodResultado;
        private string prodSintese;
        //NOR
        private int norTotal;
        private int norPercentil;
        private string norResultado;
        private string norSintese;
        //
        private int prod;
        private int nor;
        private string tab;


        public int ProdTotal { get => prodTotal; set => prodTotal = value; }
        public int ProdPercentil { get => prodPercentil; set => prodPercentil = value; }
        public string ProdResultado { get => prodResultado; set => prodResultado = value; }
        public string ProdSintese { get => prodSintese; set => prodSintese = value; }
        public int NorTotal { get => norTotal; set => norTotal = value; }
        public int NorPercentil { get => norPercentil; set => norPercentil = value; }
        public string NorResultado { get => norResultado; set => norResultado = value; }
        public string NorSintese { get => norSintese; set => norSintese = value; }
        public int Prod { get => prod; set => prod = value; }
        public int Nor { get => nor; set => nor = value; }
        public string Tab { get => tab; set => tab = value; }

        //public PaloDTO(int Prod1, int Nor1)
        //{
        //    Prod = Prod1;
        //    Nor = Nor1;

        //    //int[,] PaloTab = new int[7, 15];

        ////Percentil
        //PaloTab[0, 0] = 1;
        //PaloTab[0, 1] = 5;
        //PaloTab[0, 2] = 10;
        //PaloTab[0, 3] = 20;
        //PaloTab[0, 4] = 25;
        //PaloTab[0, 5] = 30;
        //PaloTab[0, 6] = 40;
        //PaloTab[0, 7] = 50;
        //PaloTab[0, 8] = 60;
        //PaloTab[0, 9] = 70;
        //PaloTab[0, 10] = 75;
        //PaloTab[0, 11] = 80;
        //PaloTab[0, 12] = 90;
        //PaloTab[0, 13] = 95;
        //PaloTab[0, 14] = 99;

        //Tabela Sudeste


        //Tabela Nordeste
        //    PaloTab[2, 0] = 1;
        //    PaloTab[2, 1] = 5;
        //    PaloTab[2, 2] = 10;
        //    PaloTab[2, 3] = 20;
        //    PaloTab[2, 4] = 25;
        //    PaloTab[2, 5] = 30;
        //    PaloTab[2, 6] = 40;
        //    PaloTab[2, 7] = 50;
        //    PaloTab[2, 8] = 60;
        //    PaloTab[2, 9] = 70;
        //    PaloTab[2, 10] = 75;
        //    PaloTab[2, 11] = 80;
        //    PaloTab[2, 12] = 90;
        //    PaloTab[2, 13] = 95;
        //    PaloTab[2, 14] = 99;

        //    //Tabela Sul
        //    PaloTab[3, 0] = 1;
        //    PaloTab[3, 1] = 5;
        //    PaloTab[3, 2] = 10;
        //    PaloTab[3, 3] = 20;
        //    PaloTab[3, 4] = 25;
        //    PaloTab[3, 5] = 30;
        //    PaloTab[3, 6] = 40;
        //    PaloTab[3, 7] = 50;
        //    PaloTab[3, 8] = 60;
        //    PaloTab[3, 9] = 70;
        //    PaloTab[3, 10] = 75;
        //    PaloTab[3, 11] = 80;
        //    PaloTab[3, 12] = 90;
        //    PaloTab[3, 13] = 95;
        //    PaloTab[3, 14] = 99;

        //    //Tabela Norte
        //    PaloTab[4, 0] = 1;
        //    PaloTab[4, 1] = 5;
        //    PaloTab[4, 2] = 10;
        //    PaloTab[4, 3] = 20;
        //    PaloTab[4, 4] = 25;
        //    PaloTab[4, 5] = 30;
        //    PaloTab[4, 6] = 40;
        //    PaloTab[4, 7] = 50;
        //    PaloTab[4, 8] = 60;
        //    PaloTab[4, 9] = 70;
        //    PaloTab[4, 10] = 75;
        //    PaloTab[4, 11] = 80;
        //    PaloTab[4, 12] = 90;
        //    PaloTab[4, 13] = 95;
        //    PaloTab[4, 14] = 99;

        //    //Tabela Centro-Oeste
        //    PaloTab[5, 0] = 1;
        //    PaloTab[5, 1] = 5;
        //    PaloTab[5, 2] = 10;
        //    PaloTab[5, 3] = 20;
        //    PaloTab[5, 4] = 25;
        //    PaloTab[5, 5] = 30;
        //    PaloTab[5, 6] = 40;
        //    PaloTab[5, 7] = 50;
        //    PaloTab[5, 8] = 60;
        //    PaloTab[5, 9] = 70;
        //    PaloTab[5, 10] = 75;
        //    PaloTab[5, 11] = 80;
        //    PaloTab[5, 12] = 90;
        //    PaloTab[5, 13] = 95;
        //    PaloTab[5, 14] = 99;

        //    //Tabela Amostra Total

        //    PaloTab[6, 0] = 1;
        //    PaloTab[6, 1] = 5;
        //    PaloTab[6, 2] = 10;
        //    PaloTab[6, 3] = 20;
        //    PaloTab[6, 4] = 25;
        //    PaloTab[6, 5] = 30;
        //    PaloTab[6, 6] = 40;
        //    PaloTab[6, 7] = 50;
        //    PaloTab[6, 8] = 60;
        //    PaloTab[6, 9] = 70;
        //    PaloTab[6, 10] = 75;
        //    PaloTab[6, 11] = 80;
        //    PaloTab[6, 12] = 90;
        //    PaloTab[6, 13] = 95;
        //    PaloTab[6, 14] = 99;

        //    public 
    }
}

        


   

