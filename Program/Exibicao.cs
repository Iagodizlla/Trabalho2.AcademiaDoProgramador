using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Exibicao
    {
        public static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|        * Robô Tupiniquim    *     *|");
            Console.WriteLine("--------------------------------------");
        }
        public static char ExibirMenu()
        {
            ExibirCabecalho();
            char m;
            Console.WriteLine("|               MENU                 |");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|              Sair - 0              |");
            Console.WriteLine("|            Utilizar - 1            |");
            Console.WriteLine("|            Tutorial - 2            |");
            Console.WriteLine("--------------------------------------");
            return m = char.Parse(Console.ReadLine()!);
        }
        public static void ExibirRespostaFinal(string robo1, string robo2)
        {
            ExibirCabecalho();
            if (robo1 == "Erro")
            {
                Console.WriteLine("Robo 1 saiu da grid de simulacao");
            }
            else
            {
                Console.WriteLine($"\nposicao final robo 1: {robo1}");
            }
            if (robo2 == "Erro")
            {
                Console.WriteLine("Robo 2 saiu da grid de simulacao");
            }
            else
            {
                Console.WriteLine($"posicao final robo 2: {robo2}");
            }
            Console.ReadLine();
        }
        public static void ExibirTutorial()
        {
            ExibirCabecalho();
            Console.WriteLine("\nComo digitar corretamente a Grid inicial:\n" +
                "- A grid inicial é basicamnete o plano cartesiano, só que sem a parte das numeros negativos.\n" +
                "- Ela é formada pelos eixos X e Y, onde X é a horizontal e Y a vertical.\n" +
                "- Na hora de escrever o tamanho da grid no console, digite: (numero | espaço | numero).\n" +
                "- Exemplo: 20 40\n");
            Console.WriteLine("Como digitar corretamente a posicao inicial do robo:\n" +
                "- Primeiro se digita em que posicao na grid ele esta, igual falamos no tutorial anterior.\n" +
                "- Segunda parte é pra que lado ele está virado Norte(N), Oeste(O), Sul(S) ou Letse(L).\n" +
                "- Na hora de escrever isso no console, digite: (numero | espaço | numero | espaço | letra).\n" +
                "- Exemplo: 5 8 N\n");
            Console.WriteLine("Como digitar corretamente a movimentacao do robo:\n" +
                "- Temos três(3) opções de movimentação, Esquerdo(E), Direito(D) e Medio(M).\n" +
                "- As opções E e D, são para o robo virar para o lado, ele não se move de lugar, somente gira no próprio eixo.\n" +
                "- A opção M só se move um espaço para frente de forma reta, sem poder se mexer pros lados.\n" +
                "- A quantidade de comandos de uma só vez é praticamente ilimitada, podendo ir de 1 comando a 50 se quiser.\n" +
                "- Na hora de escrever isso no console, digite: (letra | letra | letra...     ... letra | letra).\n" +
                "- Exemplo: EMEMMDDMMM");
            Console.ReadLine();
        }
        public static void ExibirOpcaoMenuInvalido()
        {
            Console.WriteLine("Opcao invalida");
            Console.ReadLine();
        }
        public static string AtribuirPosicaoFinalRobo(int posicaoXAtual, int posicaoYAtual, int XM, int YM, char DA)
        {
            if (Verificadores.VerificarIfPosicaoFinal(posicaoXAtual, posicaoYAtual, XM, YM))
            {
                return $"{posicaoXAtual} {posicaoYAtual} {DA}";
            }
            else
            {
                return "Erro";
            }
        }
    }
}