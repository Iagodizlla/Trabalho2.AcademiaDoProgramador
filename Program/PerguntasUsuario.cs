using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class PerguntasUsuario
    {
        public static string[] PerguntarTamanhoGrid(char[] separadores)
        {
            Exibicao.ExibirCabecalho();

            Console.WriteLine("Qual o tamanho da Grid(X e Y)? ");
            string tg = Console.ReadLine()!;
            string[] grid = tg.Split(separadores);
            return grid;
        }
        public static string[] PerguntarPosicaoInicial(char[] separadores, int j)
        {
            Exibicao.ExibirCabecalho();
            Console.WriteLine($"Qual o posicao inicial do robo {j + 1}? ");
            string pi = Console.ReadLine()!;
            string[] posicaoI = pi.Split(separadores);
            return posicaoI;
        }
        public static char[] PerguntarMovimentacao()
        {
            Exibicao.ExibirCabecalho();
            Console.WriteLine("Qual a movimentacao do robo(E, D ou M)? ");
            string movimentos = Console.ReadLine()!.ToUpper();
            char[] movi = movimentos.ToCharArray();
            return movi;
        }
    }
}