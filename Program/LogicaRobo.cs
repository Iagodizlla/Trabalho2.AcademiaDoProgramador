using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class LogicaRobo
    {
        public static char MudarEixoDeDirecao(char DA, char[] movi, int i)
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
            return DA;
        }
        public static int AlterarDirecaoY(char DA, int posicaoYAtual)
        {
            switch (DA)
            {
                case 'N': posicaoYAtual++; break;
                case 'S': posicaoYAtual--; break;
            }
            return posicaoYAtual;
        }
        public static int AlterarDirecaoX(char DA, int posicaoXAtual)
        {
            switch (DA)
            {
                case 'O': posicaoXAtual++; break;
                case 'L': posicaoXAtual--; break;
            }
            return posicaoXAtual;
        }
    }
}