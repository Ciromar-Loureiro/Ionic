using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crivo.Code.DTO
{
    public class PaloProd
    {
        public PaloProd()
        {
        }

        internal PerfilProd Produtividade(params int[] Prod)
        {
            int TabProd = Prod[0];
            int TabNor = Prod[1];
            int T1 = Prod[2];
            int T2 = Prod[3];
            int T3 = Prod[4];
            int T4 = Prod[5];
            int T5 = Prod[6];
            int V1 = Math.Abs(T1 - T2);
            int V2 = Math.Abs(T2 - T3);
            int V3 = Math.Abs(T3 - T4);
            int V4 = Math.Abs(T4 - T5);

            PerfilProd perfilProd = new PerfilProd();

            perfilProd.TotalT = T1 + T2 + T3 + T4 + T5;
            perfilProd.TotalV = V1 + V2 + V3 + V4;
            perfilProd.Nor = (perfilProd.TotalV * 100) / perfilProd.TotalT;

            int[,] ProdTab = new int[2, 15];
            Double[] NorTab = new double[15];

            //Percentil
            ProdTab[0, 0] = 1;
            ProdTab[0, 1] = 5;
            ProdTab[0, 2] = 10;
            ProdTab[0, 3] = 20;
            ProdTab[0, 4] = 25;
            ProdTab[0, 5] = 30;
            ProdTab[0, 6] = 40;
            ProdTab[0, 7] = 50;
            ProdTab[0, 8] = 60;
            ProdTab[0, 9] = 70;
            ProdTab[0, 10] = 75;
            ProdTab[0, 11] = 80;
            ProdTab[0, 12] = 90;
            ProdTab[0, 13] = 95;
            ProdTab[0, 14] = 99;


            #region Tabelas

            switch (TabProd)
            {
                //encontrar os valores e colocar na tabela
                case 85:
                    ProdTab[1, 0] = 158;
                    ProdTab[1, 1] = 230;
                    ProdTab[1, 2] = 267;
                    ProdTab[1, 3] = 324;
                    ProdTab[1, 4] = 348;
                    ProdTab[1, 5] = 377;
                    ProdTab[1, 6] = 421;
                    ProdTab[1, 7] = 466;
                    ProdTab[1, 8] = 514;
                    ProdTab[1, 9] = 571;
                    ProdTab[1, 10] = 607;
                    ProdTab[1, 11] = 650;
                    ProdTab[1, 12] = 754;
                    ProdTab[1, 13] = 862;
                    ProdTab[1, 14] = 1034;
                    break;
                case 86:
                    ProdTab[1, 0] = 229;
                    ProdTab[1, 1] = 284;
                    ProdTab[1, 2] = 325;
                    ProdTab[1, 3] = 393;
                    ProdTab[1, 4] = 419;
                    ProdTab[1, 5] = 455;
                    ProdTab[1, 6] = 506;
                    ProdTab[1, 7] = 569;
                    ProdTab[1, 8] = 626;
                    ProdTab[1, 9] = 691;
                    ProdTab[1, 10] = 723;
                    ProdTab[1, 11] = 755;
                    ProdTab[1, 12] = 867;
                    ProdTab[1, 13] = 939;
                    ProdTab[1, 14] = 1076;
                    break;
                case 87:
                    ProdTab[1, 0] = 152;
                    ProdTab[1, 1] = 216;
                    ProdTab[1, 2] = 249;
                    ProdTab[1, 3] = 300;
                    ProdTab[1, 4] = 325;
                    ProdTab[1, 5] = 347;
                    ProdTab[1, 6] = 391;
                    ProdTab[1, 7] = 432;
                    ProdTab[1, 8] = 469;
                    ProdTab[1, 9] = 518;
                    ProdTab[1, 10] = 548;
                    ProdTab[1, 11] = 580;
                    ProdTab[1, 12] = 666;
                    ProdTab[1, 13] = 758;
                    ProdTab[1, 14] = 962;
                    break;
                case 88:
                    ProdTab[1, 0] = 121;
                    ProdTab[1, 1] = 178;
                    ProdTab[1, 2] = 216;
                    ProdTab[1, 3] = 256;
                    ProdTab[1, 4] = 272;
                    ProdTab[1, 5] = 286;
                    ProdTab[1, 6] = 325;
                    ProdTab[1, 7] = 367;
                    ProdTab[1, 8] = 398;
                    ProdTab[1, 9] = 433;
                    ProdTab[1, 10] = 448;
                    ProdTab[1, 11] = 476;
                    ProdTab[1, 12] = 552;
                    ProdTab[1, 13] = 630;
                    ProdTab[1, 14] = 733;
                    break;
                case 89:
                    ProdTab[1, 0] = 162;
                    ProdTab[1, 1] = 235;
                    ProdTab[1, 2] = 268;
                    ProdTab[1, 3] = 319;
                    ProdTab[1, 4] = 343;
                    ProdTab[1, 5] = 365;
                    ProdTab[1, 6] = 407;
                    ProdTab[1, 7] = 453;
                    ProdTab[1, 8] = 497;
                    ProdTab[1, 9] = 559;
                    ProdTab[1, 10] = 588;
                    ProdTab[1, 11] = 636;
                    ProdTab[1, 12] = 752;
                    ProdTab[1, 13] = 844;
                    ProdTab[1, 14] = 1042;
                    break;
                case 90:
                    ProdTab[1, 0] = 191;
                    ProdTab[1, 1] = 259;
                    ProdTab[1, 2] = 302;
                    ProdTab[1, 3] = 377;
                    ProdTab[1, 4] = 400;
                    ProdTab[1, 5] = 426;
                    ProdTab[1, 6] = 473;
                    ProdTab[1, 7] = 516;
                    ProdTab[1, 8] = 564;
                    ProdTab[1, 9] = 626;
                    ProdTab[1, 10] = 658;
                    ProdTab[1, 11] = 694;
                    ProdTab[1, 12] = 799;
                    ProdTab[1, 13] = 900;
                    ProdTab[1, 14] = 1038;
                    break;
                default:
                    MessageBox.Show("Tabela Não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            switch (TabNor)
            {
                case 91:
                    NorTab[0] = 1.2;
                    NorTab[1] = 2.0;
                    NorTab[2] = 2.6;
                    NorTab[3] = 3.4;
                    NorTab[4] = 3.8;
                    NorTab[5] = 4.2;
                    NorTab[6] = 4.9;
                    NorTab[7] = 5.8;
                    NorTab[8] = 6.7;
                    NorTab[9] = 8.0;
                    NorTab[10] = 8.6;
                    NorTab[11] = 9.7;
                    NorTab[12] = 12.8;
                    NorTab[13] = 15.6;
                    NorTab[14] = 23.6;
                    break;
                case 92:
                    NorTab[0] = 1.2;
                    NorTab[1] = 2.1;
                    NorTab[2] = 2.8;
                    NorTab[3] = 3.6;
                    NorTab[4] = 4.0;
                    NorTab[5] = 4.4;
                    NorTab[6] = 5.2;
                    NorTab[7] = 6.1;
                    NorTab[8] = 7.1;
                    NorTab[9] = 8.2;
                    NorTab[10] = 8.8;
                    NorTab[11] = 9.8;
                    NorTab[12] = 12.9;
                    NorTab[13] = 15.7;
                    NorTab[14] = 24.2;
                    break;
                default:
                    MessageBox.Show("Tabela Não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            #endregion

            #region Encontrando os resultados

            for (int i = 0; i < ProdTab.Length-1; i++)
            {
                if (i==0)
                {                
                    if (perfilProd.TotalT< ProdTab[1,i+1])
                    {
                        perfilProd.PercentilProd = ProdTab[0, i];
                        break;
                    }

                    if (perfilProd.TotalV < NorTab[i + 1])
                    {
                        perfilProd.PercentilNor = ProdTab[0, i];
                        break;
                    }
                }
                else
                {
                    if (i == ProdTab.Length - 1)
                    {
                        if (perfilProd.TotalT >= ProdTab[1, i])
                        {
                            perfilProd.PercentilProd = ProdTab[0, i];
                            break;
                        }

                        if (perfilProd.TotalV >= NorTab[i])
                        {
                            perfilProd.PercentilNor = ProdTab[0, i];
                            break;
                        }
                    }
                    else
                    {
                        if (perfilProd.TotalT >= ProdTab[1,i] && perfilProd.TotalT < ProdTab[1, i+1])
                        {
                            perfilProd.PercentilProd = ProdTab[0, i];
                            break;
                        }

                        if (perfilProd.TotalV >= NorTab[i] && perfilProd.TotalV < NorTab[i + 1])
                        {
                            perfilProd.PercentilNor = ProdTab[0, i];
                            break;
                        }
                    }
                }
            }

            

            #endregion



            return perfilProd;

        }
    }
}
