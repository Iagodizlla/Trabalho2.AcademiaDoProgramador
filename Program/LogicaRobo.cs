using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class LogicaRobo
    {
        #region Objetos de robo
        public int posicaoXAtual;
        public int posicaoYAtual;
        public char DA;
        #endregion
        public static void MudarEixoDeDirecao(ref char DA, char[] movi, int i)
        {
            if (movi[i] == 'E')
            {
                switch (DA)
                {
                    case 'N': DA = 'O'; break;
                    case 'O': DA = 'S'; break;
                    case 'S': DA = 'L'; break;
                    case 'L': DA = 'N'; break;
                }
            }
            else if (movi[i] == 'D')
            {
                switch (DA)
                {
                    case 'N': DA = 'L'; break;
                    case 'O': DA = 'N'; break;
                    case 'S': DA = 'O'; break;
                    case 'L': DA = 'S'; break;
                }
            }
        }
        public static void AlterarDirecaoY(char DA, ref int posicaoYAtual)
        {
            switch (DA)
            {
                case 'N': posicaoYAtual++; break;
                case 'S': posicaoYAtual--; break;
                default: break;
            }
        }
        public static void AlterarDirecaoX(char DA, ref int posicaoXAtual)
        {
            switch (DA)
            {
                case 'O': posicaoXAtual--; break;
                case 'L': posicaoXAtual++; break;
                default: break;
            }
        }
    }
}