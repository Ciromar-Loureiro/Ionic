using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crivo.Code.DTO
{
    public class PalograficoDTO
    {

        #region declarações

        private int totalT, totalV, v1, v2, v3, v4;
        private Double nor;
        private string prodRes, prodSint, norResult, norSint;

        public int TotalT { get => totalT; set => totalT = value; }
        public int TotalV { get => totalV; set => totalV = value; }
        public int V1 { get => v1; set => v1 = value; }
        public int V2 { get => v2; set => v2 = value; }
        public int V3 { get => v3; set => v3 = value; }
        public int V4 { get => v4; set => v4 = value; }
        public double Nor { get => nor; set => nor = value; }
        public string ProdRes { get => prodRes; set => prodRes = value; }
        public string ProdSint { get => prodSint; set => prodSint = value; }
        public string NorResult { get => norResult; set => norResult = value; }
        public string NorSint { get => norSint; set => norSint = value; }
        #endregion

        public PalograficoDTO()
        {

        }

        internal static int PercentilProd(int resultado, int tabela)
        {
            //esse método vai pegar o resultado obtido e tabela escolhida para
            //encontrar o percentil da produtividade

            int resPercentil = 0;

            try
            {
                
                //variável para armazenar os valores do percentil
                int[] PercentTab = new int[15];
                //variável para armazenar os valores da tabela
                int[] ProdTab = new int[15];

                //preenchendo os valores da tabela percentil
                PercentTab[0] = 1;
                PercentTab[1] = 5;
                PercentTab[2] = 10;
                PercentTab[3] = 20;
                PercentTab[4] = 25;
                PercentTab[5] = 30;
                PercentTab[6] = 40;
                PercentTab[7] = 50;
                PercentTab[8] = 60;
                PercentTab[9] = 70;
                PercentTab[10] = 75;
                PercentTab[11] = 80;
                PercentTab[12] = 90;
                PercentTab[13] = 95;
                PercentTab[14] = 99;

                //Preenchendo os valores da tabela produtividade de acordo com
                //a tabela escolhida

                switch (tabela)
                {
                    #region Tabela Produtividade
                    case 187:
                        ProdTab[0] = 166;
                        ProdTab[1] = 229;
                        ProdTab[2] = 270;
                        ProdTab[3] = 327;
                        ProdTab[4] = 354;
                        ProdTab[5] = 378;
                        ProdTab[6] = 423;
                        ProdTab[7] = 469;
                        ProdTab[8] = 514;
                        ProdTab[9] = 570;
                        ProdTab[10] = 602;
                        ProdTab[11] = 644;
                        ProdTab[12] = 742;
                        ProdTab[13] = 841;
                        ProdTab[14] = 1088;
                        break;
                    case 188:
                        ProdTab[0] = 192;
                        ProdTab[1] = 267;
                        ProdTab[2] = 304;
                        ProdTab[3] = 378;
                        ProdTab[4] = 404;
                        ProdTab[5] = 432;
                        ProdTab[6] = 486;
                        ProdTab[7] = 533;
                        ProdTab[8] = 589;
                        ProdTab[9] = 658;
                        ProdTab[10] = 689;
                        ProdTab[11] = 723;
                        ProdTab[12] = 834;
                        ProdTab[13] = 916;
                        ProdTab[14] = 1062;
                        break;
                    case 189:
                        ProdTab[0] = 157;
                        ProdTab[1] = 217;
                        ProdTab[2] = 257;
                        ProdTab[3] = 310;
                        ProdTab[4] = 333;
                        ProdTab[5] = 358;
                        ProdTab[6] = 400;
                        ProdTab[7] = 441;
                        ProdTab[8] = 485;
                        ProdTab[9] = 533;
                        ProdTab[10] = 561;
                        ProdTab[11] = 596;
                        ProdTab[12] = 683;
                        ProdTab[13] = 770;
                        ProdTab[14] = 952;
                        break;
                    case 190:
                        ProdTab[0] = 129;
                        ProdTab[1] = 188;
                        ProdTab[2] = 216;
                        ProdTab[3] = 270;
                        ProdTab[4] = 284;
                        ProdTab[5] = 304;
                        ProdTab[6] = 343;
                        ProdTab[7] = 378;
                        ProdTab[8] = 410;
                        ProdTab[9] = 456;
                        ProdTab[10] = 484;
                        ProdTab[11] = 508;
                        ProdTab[12] = 601;
                        ProdTab[13] = 666;
                        ProdTab[14] = 810;
                        break;
                    case 191:
                        ProdTab[0] = 176;
                        ProdTab[1] = 233;
                        ProdTab[2] = 272;
                        ProdTab[3] = 326;
                        ProdTab[4] = 349;
                        ProdTab[5] = 374;
                        ProdTab[6] = 418;
                        ProdTab[7] = 459;
                        ProdTab[8] = 502;
                        ProdTab[9] = 556;
                        ProdTab[10] = 585;
                        ProdTab[11] = 622;
                        ProdTab[12] = 721;
                        ProdTab[13] = 823;
                        ProdTab[14] = 982;
                        break;
                    case 192:
                        ProdTab[0] = 191;
                        ProdTab[1] = 263;
                        ProdTab[2] = 309;
                        ProdTab[3] = 381;
                        ProdTab[4] = 412;
                        ProdTab[5] = 437;
                        ProdTab[6] = 484;
                        ProdTab[7] = 529;
                        ProdTab[8] = 576;
                        ProdTab[9] = 640;
                        ProdTab[10] = 667;
                        ProdTab[11] = 701;
                        ProdTab[12] = 803;
                        ProdTab[13] = 897;
                        ProdTab[14] = 1053;
                        break;
                    case 85:
                        ProdTab[0] = 158;
                        ProdTab[1] = 230;
                        ProdTab[2] = 267;
                        ProdTab[3] = 324;
                        ProdTab[4] = 348;
                        ProdTab[5] = 377;
                        ProdTab[6] = 421;
                        ProdTab[7] = 466;
                        ProdTab[8] = 514;
                        ProdTab[9] = 571;
                        ProdTab[10] = 607;
                        ProdTab[11] = 650;
                        ProdTab[12] = 754;
                        ProdTab[13] = 862;
                        ProdTab[14] = 1034;
                        break;
                    case 86:
                        ProdTab[0] = 229;
                        ProdTab[1] = 284;
                        ProdTab[2] = 325;
                        ProdTab[3] = 393;
                        ProdTab[4] = 419;
                        ProdTab[5] = 455;
                        ProdTab[6] = 506;
                        ProdTab[7] = 569;
                        ProdTab[8] = 626;
                        ProdTab[9] = 691;
                        ProdTab[10] = 723;
                        ProdTab[11] = 755;
                        ProdTab[12] = 867;
                        ProdTab[13] = 939;
                        ProdTab[14] = 1076;
                        break;
                    case 87:
                        ProdTab[0] = 152;
                        ProdTab[1] = 216;
                        ProdTab[2] = 249;
                        ProdTab[3] = 300;
                        ProdTab[4] = 325;
                        ProdTab[5] = 347;
                        ProdTab[6] = 391;
                        ProdTab[7] = 432;
                        ProdTab[8] = 469;
                        ProdTab[9] = 518;
                        ProdTab[10] = 548;
                        ProdTab[11] = 580;
                        ProdTab[12] = 666;
                        ProdTab[13] = 758;
                        ProdTab[14] = 962;
                        break;
                    case 88:
                        ProdTab[0] = 121;
                        ProdTab[1] = 178;
                        ProdTab[2] = 216;
                        ProdTab[3] = 256;
                        ProdTab[4] = 272;
                        ProdTab[5] = 286;
                        ProdTab[6] = 325;
                        ProdTab[7] = 367;
                        ProdTab[8] = 398;
                        ProdTab[9] = 433;
                        ProdTab[10] = 448;
                        ProdTab[11] = 476;
                        ProdTab[12] = 552;
                        ProdTab[13] = 630;
                        ProdTab[14] = 733;
                        break;
                    case 89:
                        ProdTab[0] = 162;
                        ProdTab[1] = 235;
                        ProdTab[2] = 268;
                        ProdTab[3] = 319;
                        ProdTab[4] = 343;
                        ProdTab[5] = 365;
                        ProdTab[6] = 407;
                        ProdTab[7] = 453;
                        ProdTab[8] = 497;
                        ProdTab[9] = 559;
                        ProdTab[10] = 588;
                        ProdTab[11] = 636;
                        ProdTab[12] = 752;
                        ProdTab[13] = 844;
                        ProdTab[14] = 1042;
                        break;
                    case 90:
                        ProdTab[0] = 191;
                        ProdTab[1] = 259;
                        ProdTab[2] = 302;
                        ProdTab[3] = 377;
                        ProdTab[4] = 400;
                        ProdTab[5] = 426;
                        ProdTab[6] = 473;
                        ProdTab[7] = 516;
                        ProdTab[8] = 564;
                        ProdTab[9] = 626;
                        ProdTab[10] = 658;
                        ProdTab[11] = 694;
                        ProdTab[12] = 799;
                        ProdTab[13] = 900;
                        ProdTab[14] = 1038;
                        break;
                    case 106:
                        ProdTab[0] = 196;
                        ProdTab[1] = 282;
                        ProdTab[2] = 321;
                        ProdTab[3] = 380;
                        ProdTab[4] = 406;
                        ProdTab[5] = 427;
                        ProdTab[6] = 472;
                        ProdTab[7] = 513;
                        ProdTab[8] = 555;
                        ProdTab[9] = 607;
                        ProdTab[10] = 641;
                        ProdTab[11] = 671;
                        ProdTab[12] = 763;
                        ProdTab[13] = 866;
                        ProdTab[14] = 1028;
                        break;
                    case 107:
                        ProdTab[0] = 208;
                        ProdTab[1] = 301;
                        ProdTab[2] = 357;
                        ProdTab[3] = 425;
                        ProdTab[4] = 452;
                        ProdTab[5] = 469;
                        ProdTab[6] = 510;
                        ProdTab[7] = 548;
                        ProdTab[8] = 615;
                        ProdTab[9] = 663;
                        ProdTab[10] = 693;
                        ProdTab[11] = 723;
                        ProdTab[12] = 815;
                        ProdTab[13] = 930;
                        ProdTab[14] = 1116;
                        break;
                    case 108:
                        ProdTab[0] = 194;
                        ProdTab[1] = 277;
                        ProdTab[2] = 311;
                        ProdTab[3] = 360;
                        ProdTab[4] = 384;
                        ProdTab[5] = 407;
                        ProdTab[6] = 456;
                        ProdTab[7] = 497;
                        ProdTab[8] = 533;
                        ProdTab[9] = 578;
                        ProdTab[10] = 605;
                        ProdTab[11] = 643;
                        ProdTab[12] = 738;
                        ProdTab[13] = 833;
                        ProdTab[14] = 982;
                        break;
                    case 109:
                        ProdTab[0] = 127;
                        ProdTab[1] = 197;
                        ProdTab[2] = 286;
                        ProdTab[3] = 325;
                        ProdTab[4] = 339;
                        ProdTab[5] = 357;
                        ProdTab[6] = 378;
                        ProdTab[7] = 413;
                        ProdTab[8] = 455;
                        ProdTab[9] = 514;
                        ProdTab[10] = 545;
                        ProdTab[11] = 571;
                        ProdTab[12] = 626;
                        ProdTab[13] = 686;
                        ProdTab[14] = 894;
                        break;
                    case 110:
                        ProdTab[0] = 210;
                        ProdTab[1] = 282;
                        ProdTab[2] = 321;
                        ProdTab[3] = 386;
                        ProdTab[4] = 410;
                        ProdTab[5] = 431;
                        ProdTab[6] = 472;
                        ProdTab[7] = 507;
                        ProdTab[8] = 543;
                        ProdTab[9] = 591;
                        ProdTab[10] = 626;
                        ProdTab[11] = 664;
                        ProdTab[12] = 766;
                        ProdTab[13] = 847;
                        ProdTab[14] = 974;
                        break;
                    case 111:
                        ProdTab[0] = 230;
                        ProdTab[1] = 298;
                        ProdTab[2] = 359;
                        ProdTab[3] = 425;
                        ProdTab[4] = 458;
                        ProdTab[5] = 474;
                        ProdTab[6] = 522;
                        ProdTab[7] = 565;
                        ProdTab[8] = 617;
                        ProdTab[9] = 665;
                        ProdTab[10] = 684;
                        ProdTab[11] = 713;
                        ProdTab[12] = 813;
                        ProdTab[13] = 913;
                        ProdTab[14] = 1130;
                        break;
                    case 126:
                        ProdTab[0] = 166;
                        ProdTab[1] = 236;
                        ProdTab[2] = 273;
                        ProdTab[3] = 332;
                        ProdTab[4] = 354;
                        ProdTab[5] = 374;
                        ProdTab[6] = 416;
                        ProdTab[7] = 464;
                        ProdTab[8] = 512;
                        ProdTab[9] = 577;
                        ProdTab[10] = 602;
                        ProdTab[11] = 627;
                        ProdTab[12] = 708;
                        ProdTab[13] = 786;
                        ProdTab[14] = 931;
                        break;
                    case 127:
                        ProdTab[0] = 159;
                        ProdTab[1] = 244;
                        ProdTab[2] = 279;
                        ProdTab[3] = 345;
                        ProdTab[4] = 363;
                        ProdTab[5] = 386;
                        ProdTab[6] = 430;
                        ProdTab[7] = 481;
                        ProdTab[8] = 557;
                        ProdTab[9] = 610;
                        ProdTab[10] = 639;
                        ProdTab[11] = 676;
                        ProdTab[12] = 735;
                        ProdTab[13] = 831;
                        ProdTab[14] = 992;
                        break;
                    case 128:
                        ProdTab[0] = 154;
                        ProdTab[1] = 235;
                        ProdTab[2] = 272;
                        ProdTab[3] = 319;
                        ProdTab[4] = 346;
                        ProdTab[5] = 367;
                        ProdTab[6] = 405;
                        ProdTab[7] = 458;
                        ProdTab[8] = 503;
                        ProdTab[9] = 557;
                        ProdTab[10] = 582;
                        ProdTab[11] = 608;
                        ProdTab[12] = 682;
                        ProdTab[13] = 776;
                        ProdTab[14] = 890;
                        break;
                    case 129:
                        ProdTab[0] = 146;
                        ProdTab[1] = 199;
                        ProdTab[2] = 261;
                        ProdTab[3] = 296;
                        ProdTab[4] = 319;
                        ProdTab[5] = 343;
                        ProdTab[6] = 375;
                        ProdTab[7] = 398;
                        ProdTab[8] = 429;
                        ProdTab[9] = 503;
                        ProdTab[10] = 521;
                        ProdTab[11] = 570;
                        ProdTab[12] = 661;
                        ProdTab[13] = 758;
                        ProdTab[14] = 929;
                        break;
                    case 130:
                        ProdTab[0] = 177;
                        ProdTab[1] = 240;
                        ProdTab[2] = 272;
                        ProdTab[3] = 320;
                        ProdTab[4] = 346;
                        ProdTab[5] = 361;
                        ProdTab[6] = 406;
                        ProdTab[7] = 452;
                        ProdTab[8] = 492;
                        ProdTab[9] = 564;
                        ProdTab[10] = 594;
                        ProdTab[11] = 608;
                        ProdTab[12] = 690;
                        ProdTab[13] = 771;
                        ProdTab[14] = 882;
                        break;
                    case 131:
                        ProdTab[0] = 163;
                        ProdTab[1] = 248;
                        ProdTab[2] = 299;
                        ProdTab[3] = 372;
                        ProdTab[4] = 407;
                        ProdTab[5] = 431;
                        ProdTab[6] = 486;
                        ProdTab[7] = 539;
                        ProdTab[8] = 585;
                        ProdTab[9] = 628;
                        ProdTab[10] = 649;
                        ProdTab[11] = 680;
                        ProdTab[12] = 759;
                        ProdTab[13] = 836;
                        ProdTab[14] = 1032;
                        break;
                    case 146:
                        ProdTab[0] = 136;
                        ProdTab[1] = 191;
                        ProdTab[2] = 221;
                        ProdTab[3] = 273;
                        ProdTab[4] = 295;
                        ProdTab[5] = 318;
                        ProdTab[6] = 358;
                        ProdTab[7] = 391;
                        ProdTab[8] = 437;
                        ProdTab[9] = 484;
                        ProdTab[10] = 507;
                        ProdTab[11] = 543;
                        ProdTab[12] = 649;
                        ProdTab[13] = 740;
                        ProdTab[14] = 945;
                        break;
                    case 147:
                        ProdTab[0] = 147;
                        ProdTab[1] = 204;
                        ProdTab[2] = 241;
                        ProdTab[3] = 298;
                        ProdTab[4] = 323;
                        ProdTab[5] = 350;
                        ProdTab[6] = 392;
                        ProdTab[7] = 443;
                        ProdTab[8] = 503;
                        ProdTab[9] = 543;
                        ProdTab[10] = 598;
                        ProdTab[11] = 639;
                        ProdTab[12] = 722;
                        ProdTab[13] = 828;
                        ProdTab[14] = 1075;
                        break;
                    case 148:
                        ProdTab[0] = 127;
                        ProdTab[1] = 185;
                        ProdTab[2] = 211;
                        ProdTab[3] = 264;
                        ProdTab[4] = 281;
                        ProdTab[5] = 309;
                        ProdTab[6] = 343;
                        ProdTab[7] = 379;
                        ProdTab[8] = 420;
                        ProdTab[9] = 459;
                        ProdTab[10] = 484;
                        ProdTab[11] = 507;
                        ProdTab[12] = 589;
                        ProdTab[13] = 688;
                        ProdTab[14] = 819;
                        break;
                    case 149:
                        ProdTab[0] = 124;
                        ProdTab[1] = 147;
                        ProdTab[2] = 183;
                        ProdTab[3] = 209;
                        ProdTab[4] = 233;
                        ProdTab[5] = 242;
                        ProdTab[6] = 275;
                        ProdTab[7] = 308;
                        ProdTab[8] = 354;
                        ProdTab[9] = 379;
                        ProdTab[10] = 390;
                        ProdTab[11] = 419;
                        ProdTab[12] = 505;
                        ProdTab[13] = 584;
                        ProdTab[14] = 721;
                        break;
                    case 150:
                        ProdTab[0] = 153;
                        ProdTab[1] = 199;
                        ProdTab[2] = 233;
                        ProdTab[3] = 278;
                        ProdTab[4] = 310;
                        ProdTab[5] = 321;
                        ProdTab[6] = 361;
                        ProdTab[7] = 398;
                        ProdTab[8] = 434;
                        ProdTab[9] = 479;
                        ProdTab[10] = 500;
                        ProdTab[11] = 523;
                        ProdTab[12] = 609;
                        ProdTab[13] = 688;
                        ProdTab[14] = 818;
                        break;
                    case 151:
                        ProdTab[0] = 143;
                        ProdTab[1] = 210;
                        ProdTab[2] = 261;
                        ProdTab[3] = 329;
                        ProdTab[4] = 356;
                        ProdTab[5] = 380;
                        ProdTab[6] = 449;
                        ProdTab[7] = 484;
                        ProdTab[8] = 540;
                        ProdTab[9] = 593;
                        ProdTab[10] = 640;
                        ProdTab[11] = 680;
                        ProdTab[12] = 787;
                        ProdTab[13] = 902;
                        ProdTab[14] = 1128;
                        break;
                    case 167:
                        ProdTab[0] = 189;
                        ProdTab[1] = 244;
                        ProdTab[2] = 287;
                        ProdTab[3] = 355;
                        ProdTab[4] = 386;
                        ProdTab[5] = 410;
                        ProdTab[6] = 456;
                        ProdTab[7] = 493;
                        ProdTab[8] = 539;
                        ProdTab[9] = 598;
                        ProdTab[10] = 627;
                        ProdTab[11] = 675;
                        ProdTab[12] = 787;
                        ProdTab[13] = 886;
                        ProdTab[14] = 1023;
                        break;
                    case 168:
                        ProdTab[0] = 187;
                        ProdTab[1] = 255;
                        ProdTab[2] = 311;
                        ProdTab[3] = 397;
                        ProdTab[4] = 417;
                        ProdTab[5] = 448;
                        ProdTab[6] = 484;
                        ProdTab[7] = 524;
                        ProdTab[8] = 581;
                        ProdTab[9] = 650;
                        ProdTab[10] = 695;
                        ProdTab[11] = 758;
                        ProdTab[12] = 849;
                        ProdTab[13] = 902;
                        ProdTab[14] = 1058;
                        break;
                    case 169:
                        ProdTab[0] = 187;
                        ProdTab[1] = 234;
                        ProdTab[2] = 275;
                        ProdTab[3] = 339;
                        ProdTab[4] = 366;
                        ProdTab[5] = 391;
                        ProdTab[6] = 441;
                        ProdTab[7] = 480;
                        ProdTab[8] = 526;
                        ProdTab[9] = 571;
                        ProdTab[10] = 600;
                        ProdTab[11] = 647;
                        ProdTab[12] = 722;
                        ProdTab[13] = 812;
                        ProdTab[14] = 1020;
                        break;
                    case 170:
                        ProdTab[0] = 146;
                        ProdTab[1] = 198;
                        ProdTab[2] = 244;
                        ProdTab[3] = 273;
                        ProdTab[4] = 292;
                        ProdTab[5] = 318;
                        ProdTab[6] = 363;
                        ProdTab[7] = 402;
                        ProdTab[8] = 460;
                        ProdTab[9] = 492;
                        ProdTab[10] = 508;
                        ProdTab[11] = 526;
                        ProdTab[12] = 606;
                        ProdTab[13] = 681;
                        ProdTab[14] = 900;
                        break;
                    case 171:
                        ProdTab[0] = 199;
                        ProdTab[1] = 272;
                        ProdTab[2] = 320;
                        ProdTab[3] = 391;
                        ProdTab[4] = 411;
                        ProdTab[5] = 423;
                        ProdTab[6] = 470;
                        ProdTab[7] = 511;
                        ProdTab[8] = 561;
                        ProdTab[9] = 598;
                        ProdTab[10] = 631;
                        ProdTab[11] = 675;
                        ProdTab[12] = 780;
                        ProdTab[13] = 902;
                        ProdTab[14] = 1026;
                        break;
                    case 172:
                        ProdTab[0] = 178;
                        ProdTab[1] = 300;
                        ProdTab[2] = 339;
                        ProdTab[3] = 416;
                        ProdTab[4] = 453;
                        ProdTab[5] = 474;
                        ProdTab[6] = 512;
                        ProdTab[7] = 560;
                        ProdTab[8] = 622;
                        ProdTab[9] = 697;
                        ProdTab[10] = 719;
                        ProdTab[11] = 762;
                        ProdTab[12] = 846;
                        ProdTab[13] = 917;
                        ProdTab[14] = 1120;
                        break;
                    #endregion
                    default:
                        break;
                }

                #region Encontrando os resultados

                for (int i = 0; i < ProdTab.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        if (resultado < ProdTab[i + 1])
                        {
                            resPercentil = PercentTab[i];
                            break;
                        }
                    }
                    else
                    {
                        if (i == ProdTab.Length - 1)
                        {
                            if (resultado >= ProdTab[i])
                            {
                                resPercentil = PercentTab[i];
                                break;
                            }
                        }
                        else
                        {
                            if (resultado >= ProdTab[i] && resultado < ProdTab[i + 1])
                            {
                                resPercentil = PercentTab[i];
                                break;
                            }
                        }
                    }
                }
                #endregion

                return resPercentil;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            return resPercentil;
        }

        //internal static PerfilProdDTO Produtividade(int[] Prod)
        //{
        //    /*Prod é um array enviado desde o formulário com o número da tabela
        //     * de produtividade, da tabela de Nor e dos resultados obtidos em cada tempo
        //     */

        //    //string TabProd = Convert.ToString(Prod[0]);
        //    //string TabNor = Convert.ToString(Prod[1]);
        //    //string T1 = Convert.ToString(Prod[2]);
        //    //string T2 = Convert.ToString(Prod[3]);
        //    //string T3 = Convert.ToString(Prod[4]);
        //    //string T4 = Convert.ToString(Prod[5]);
        //    //string T5 = Convert.ToString(Prod[6]);

        //    //MessageBox.Show(TabProd + " " + TabNor + " " + T1 + " " + T2 + " " + T3 + " " + T4 + " " + T5);

        //    PalograficoDTO perfilProd = new PalograficoDTO();

        //    try
        //    {
        //        int TabProd = Prod[0];
        //        int TabNor = Prod[1];
        //        int T1 = Prod[2];
        //        int T2 = Prod[3];
        //        int T3 = Prod[4];
        //        int T4 = Prod[5];
        //        int T5 = Prod[6];
       

                

        //        TotalT = T1 + T2 + T3 + T4 + T5;
        //        perfilProd.TotalV = V1 + V2 + V3 + V4;
        //        perfilProd.Nor = (perfilProd.TotalV * 100) / perfilProd.TotalT;

        //        // Tabela de percentis para correção do resultado
        //        int[] tabPercentil = new int[15] { 1, 5, 10, 20, 25, 30, 40, 50, 60, 70, 75, 80, 90, 95, 99 };
        //        //Agora é preciso criar um array com os valores da tabela selecionada
        //        int[] ProdTab = new int[15];

        //        //A tabela de Produtividade escolhida está na varíavel TabProd
        //        // a de Nor em TabNor

               



        //        return perfilProd;

        //    }
        //    catch (Exception ex)            {

        //        MessageBox.Show("Ocorreu um erro: " + ex);
        //    }

        //    return perfilProd;



        //    //int[,] ProdTab = new int[2, 15];
        //    //Double[] NorTab = new double[15];

        //    ////Percentil
        //    //ProdTab[0, 0] = 1;
        //    //ProdTab[0, 1] = 5;
        //    //ProdTab[0, 2] = 10;
        //    //ProdTab[0, 3] = 20;
        //    //ProdTab[0, 4] = 25;
        //    //ProdTab[0, 5] = 30;
        //    //ProdTab[0, 6] = 40;
        //    //ProdTab[0, 7] = 50;
        //    //ProdTab[0, 8] = 60;
        //    //ProdTab[0, 9] = 70;
        //    //ProdTab[0, 10] = 75;
        //    //ProdTab[0, 11] = 80;
        //    //ProdTab[0, 12] = 90;
        //    //ProdTab[0, 13] = 95;
        //    //ProdTab[0, 14] = 99;


        //    //#region Tabelas

        //    //switch (TabProd)
        //    //{
        //    //    //encontrar os valores e colocar na tabela
        //    //    case 85:
        //    //        ProdTab[1, 0] = 158;
        //    //        ProdTab[1, 1] = 230;
        //    //        ProdTab[1, 2] = 267;
        //    //        ProdTab[1, 3] = 324;
        //    //        ProdTab[1, 4] = 348;
        //    //        ProdTab[1, 5] = 377;
        //    //        ProdTab[1, 6] = 421;
        //    //        ProdTab[1, 7] = 466;
        //    //        ProdTab[1, 8] = 514;
        //    //        ProdTab[1, 9] = 571;
        //    //        ProdTab[1, 10] = 607;
        //    //        ProdTab[1, 11] = 650;
        //    //        ProdTab[1, 12] = 754;
        //    //        ProdTab[1, 13] = 862;
        //    //        ProdTab[1, 14] = 1034;
        //    //        break;
        //    //    case 86:
        //    //        ProdTab[1, 0] = 229;
        //    //        ProdTab[1, 1] = 284;
        //    //        ProdTab[1, 2] = 325;
        //    //        ProdTab[1, 3] = 393;
        //    //        ProdTab[1, 4] = 419;
        //    //        ProdTab[1, 5] = 455;
        //    //        ProdTab[1, 6] = 506;
        //    //        ProdTab[1, 7] = 569;
        //    //        ProdTab[1, 8] = 626;
        //    //        ProdTab[1, 9] = 691;
        //    //        ProdTab[1, 10] = 723;
        //    //        ProdTab[1, 11] = 755;
        //    //        ProdTab[1, 12] = 867;
        //    //        ProdTab[1, 13] = 939;
        //    //        ProdTab[1, 14] = 1076;
        //    //        break;
        //    //    case 87:
        //    //        ProdTab[1, 0] = 152;
        //    //        ProdTab[1, 1] = 216;
        //    //        ProdTab[1, 2] = 249;
        //    //        ProdTab[1, 3] = 300;
        //    //        ProdTab[1, 4] = 325;
        //    //        ProdTab[1, 5] = 347;
        //    //        ProdTab[1, 6] = 391;
        //    //        ProdTab[1, 7] = 432;
        //    //        ProdTab[1, 8] = 469;
        //    //        ProdTab[1, 9] = 518;
        //    //        ProdTab[1, 10] = 548;
        //    //        ProdTab[1, 11] = 580;
        //    //        ProdTab[1, 12] = 666;
        //    //        ProdTab[1, 13] = 758;
        //    //        ProdTab[1, 14] = 962;
        //    //        break;
        //    //    case 88:
        //    //        ProdTab[1, 0] = 121;
        //    //        ProdTab[1, 1] = 178;
        //    //        ProdTab[1, 2] = 216;
        //    //        ProdTab[1, 3] = 256;
        //    //        ProdTab[1, 4] = 272;
        //    //        ProdTab[1, 5] = 286;
        //    //        ProdTab[1, 6] = 325;
        //    //        ProdTab[1, 7] = 367;
        //    //        ProdTab[1, 8] = 398;
        //    //        ProdTab[1, 9] = 433;
        //    //        ProdTab[1, 10] = 448;
        //    //        ProdTab[1, 11] = 476;
        //    //        ProdTab[1, 12] = 552;
        //    //        ProdTab[1, 13] = 630;
        //    //        ProdTab[1, 14] = 733;
        //    //        break;
        //    //    case 89:
        //    //        ProdTab[1, 0] = 162;
        //    //        ProdTab[1, 1] = 235;
        //    //        ProdTab[1, 2] = 268;
        //    //        ProdTab[1, 3] = 319;
        //    //        ProdTab[1, 4] = 343;
        //    //        ProdTab[1, 5] = 365;
        //    //        ProdTab[1, 6] = 407;
        //    //        ProdTab[1, 7] = 453;
        //    //        ProdTab[1, 8] = 497;
        //    //        ProdTab[1, 9] = 559;
        //    //        ProdTab[1, 10] = 588;
        //    //        ProdTab[1, 11] = 636;
        //    //        ProdTab[1, 12] = 752;
        //    //        ProdTab[1, 13] = 844;
        //    //        ProdTab[1, 14] = 1042;
        //    //        break;
        //    //    case 90:
        //    //        ProdTab[1, 0] = 191;
        //    //        ProdTab[1, 1] = 259;
        //    //        ProdTab[1, 2] = 302;
        //    //        ProdTab[1, 3] = 377;
        //    //        ProdTab[1, 4] = 400;
        //    //        ProdTab[1, 5] = 426;
        //    //        ProdTab[1, 6] = 473;
        //    //        ProdTab[1, 7] = 516;
        //    //        ProdTab[1, 8] = 564;
        //    //        ProdTab[1, 9] = 626;
        //    //        ProdTab[1, 10] = 658;
        //    //        ProdTab[1, 11] = 694;
        //    //        ProdTab[1, 12] = 799;
        //    //        ProdTab[1, 13] = 900;
        //    //        ProdTab[1, 14] = 1038;
        //    //        break;
        //    //    default:
        //    //        MessageBox.Show("Tabela Não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        break;
        //    //}

        //    //switch (TabNor)
        //    //{
        //    //    case 91:
        //    //        NorTab[0] = 1.2;
        //    //        NorTab[1] = 2.0;
        //    //        NorTab[2] = 2.6;
        //    //        NorTab[3] = 3.4;
        //    //        NorTab[4] = 3.8;
        //    //        NorTab[5] = 4.2;
        //    //        NorTab[6] = 4.9;
        //    //        NorTab[7] = 5.8;
        //    //        NorTab[8] = 6.7;
        //    //        NorTab[9] = 8.0;
        //    //        NorTab[10] = 8.6;
        //    //        NorTab[11] = 9.7;
        //    //        NorTab[12] = 12.8;
        //    //        NorTab[13] = 15.6;
        //    //        NorTab[14] = 23.6;
        //    //        break;
        //    //    case 92:
        //    //        NorTab[0] = 1.2;
        //    //        NorTab[1] = 2.1;
        //    //        NorTab[2] = 2.8;
        //    //        NorTab[3] = 3.6;
        //    //        NorTab[4] = 4.0;
        //    //        NorTab[5] = 4.4;
        //    //        NorTab[6] = 5.2;
        //    //        NorTab[7] = 6.1;
        //    //        NorTab[8] = 7.1;
        //    //        NorTab[9] = 8.2;
        //    //        NorTab[10] = 8.8;
        //    //        NorTab[11] = 9.8;
        //    //        NorTab[12] = 12.9;
        //    //        NorTab[13] = 15.7;
        //    //        NorTab[14] = 24.2;
        //    //        break;
        //    //    default:
        //    //        MessageBox.Show("Tabela Não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        break;
        //    //}
        //    //#endregion

            



        //    //#endregion





    }
}

