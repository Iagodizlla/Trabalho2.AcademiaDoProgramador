using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Verificadores
    {
        public static bool VerificarArrayGrid(string[] grid, bool erro)
        {
            erro = false;
            for (int i = 0; i < grid.Length; i++)
            {
                if (int.TryParse(grid[i], out int n))
                {
                }
                else
                {
                    Console.WriteLine("Isso não é um número válido");
                    Console.ReadLine();
                    erro = true;
                    break;
                }
            }
            return erro;
        }
        public static bool VerificarArrayPosicaoInicial(string[] posicaoI, bool erro)
        {
            erro = false;

            for (int i = 0; i < posicaoI.Length-1; i++)
            {
                if (int.TryParse(posicaoI[i], out int n))
                {
                }
                else
                {
                    Console.WriteLine("Posicao inicial invalida");
                    Console.ReadLine();
                    erro = true;
                    break;
                }
            }
            return erro;
        }
        public static bool VerificarArrayMovimentacao(char[] movi, bool erro)
        {
            for (int i = 0; i < movi.Length; i++)
            {
                if (movi[i] != 'E' && movi[i] != 'D' && movi[i] != 'M')
                {
                    Console.WriteLine("Movimentacao do robo invalida");
                    Console.ReadLine();
                    erro = true;
                    break;
                }
            }
            return erro;
        }
        public static bool VerificarIfPosicaoInicial(int XI, int YI, int XM, int YM, char DA)
        {
            if (VerificarIfPosicaoFinal(XI, YI, XM, YM) || (DA != 'N' && DA != 'S' && DA != 'O' && DA != 'L'))
            {
                return false;
            }
            return true;
        }
        public static bool VerificarIfPosicaoFinal(int posicaoXAtual, int posicaoYAtual, int XM, int YM)
        {
            if (posicaoXAtual < 0 || posicaoYAtual < 0 || posicaoXAtual > XM || posicaoYAtual > YM)
            {
                return false;
            }
            return true;
        }
    }
}