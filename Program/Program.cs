using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool erro = false;
                char[] separadores = {' '}, movi;
                int XM, YM, XI, YI, posicaoXAtual, posicaoYAtual;
                string[] grid, posicaoI;
                char m, DA;
                string robo1 = "", robo2 = "";

                m = ExibirMenu();
                if(m == '0')
                {
                    break;
                }
                else if (m == '1')
                {
                    grid = PerguntarTamanhoGrid(separadores);
                    erro = VerificarArrayGrid(grid, erro);

                    if (erro)
                    {
                        continue;
                    }

                    XM = int.Parse(grid[0]);
                    YM = int.Parse(grid[1]);

                    for (int j = 0; j < 2; j++)
                    {
                        posicaoI = PerguntarPosicaoInicial(separadores, j);
                        erro = VerificarArrayPosicaoInicial(posicaoI, erro);

                        if (erro)
                        {
                            j--;
                            continue;
                        }

                        XI = int.Parse(posicaoI[0]);
                        YI = int.Parse(posicaoI[1]);
                        DA = char.Parse(posicaoI[2].ToUpper());
                        posicaoXAtual = XI;
                        posicaoYAtual = YI;

                        if (VerificarIfPosicaoInicial(XI, YI, XM, YM, DA))
                        {
                            Console.WriteLine("Posicao inicial invalida");
                            j--;
                            continue;
                        }

                        movi = PerguntarMovimentacao(separadores);
                        erro = VerificarArrayMovimentacao(movi, erro);

                        if(erro)
                        {
                            j--;
                            continue;
                        }
                        for (int i = 0; i < movi.Length; i++)
                        {
                            DA = MudarEixoDeDirecao(DA, movi, i);

                            if (movi[i] == 'M')
                            {
                                switch (DA)
                                {
                                    case 'N': posicaoYAtual++; break;
                                    case 'O': posicaoXAtual--; break;
                                    case 'S': posicaoYAtual--; break;
                                    case 'L': posicaoXAtual++; break;
                                }
                            }
                        }
                        if (j == 0)
                        {
                            robo1 = AtribuirPosicaoFinalRobo(posicaoXAtual, posicaoYAtual, XM, YM, DA);
                        }
                        else
                        {
                            robo2 = AtribuirPosicaoFinalRobo(posicaoXAtual, posicaoYAtual, XM, YM, DA);
                        }
                    }
                    ExibirRespostaFinal(robo1, robo2);
                }
                else if (m == '2')
                {
                    ExibirTutorial();
                }
                else
                {
                    ExibirOpcaoMenuInvalido();
                }
            }
        }
        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|        * Robô Tupiniquim    *     *|");
            Console.WriteLine("--------------------------------------");
        }
        static char ExibirMenu()
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
        static void ExibirRespostaFinal(string robo1, string robo2)
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
        static void ExibirTutorial()
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
        static void ExibirOpcaoMenuInvalido()
        {
            Console.WriteLine("Opcao invalida");
            Console.ReadLine();
        }
        static bool VerificarArrayGrid(string[] grid, bool erro)
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
        static bool VerificarArrayPosicaoInicial(string[] posicaoI, bool erro)
        {
            erro = false;

            for (int i = 0; i < posicaoI.Length - 1; i++)
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
        static bool VerificarArrayMovimentacao(char[] movi, bool erro)
        {
            for (int i = 0; i < movi.Length; i++)
            {
                if (movi[i] != 'E' && movi[i] != 'D' && movi[i] != 'M')
                {
                    Console.WriteLine("Movimentacao do robo invalida");
                    erro = true;
                    break;
                }
            }
            return erro;
        }
        static string[] PerguntarTamanhoGrid(char[] separadores)
        {
            ExibirCabecalho();

            Console.WriteLine("Qual o tamanho da Grid(X e Y)? ");
            string tg = Console.ReadLine()!;
            string[] grid = tg.Split(separadores);
            return grid;
        }
        static string[] PerguntarPosicaoInicial(char[] separadores, int j)
        {
            ExibirCabecalho();

            Console.WriteLine($"Qual o posicao inicial do robo {j + 1}? ");
            string pi = Console.ReadLine()!;
            string[] posicaoI = pi.Split(separadores);
            return posicaoI;
        }
        static char[] PerguntarMovimentacao(char[] separadores)
        {
            ExibirCabecalho();

            Console.WriteLine("Qual a movimentacao do robo(E, D ou M)? ");
            string movimentos = Console.ReadLine()!.ToUpper();
            char[] movi = movimentos.ToCharArray();
            return movi;
        }
        static bool VerificarIfPosicaoInicial(int XI, int YI, int XM, int YM, char DA)
        {
            if(XI < 0 || XI > XM || YI < 0 || YI > YM || (DA != 'N' && DA != 'S' && DA != 'O' && DA != 'L'))
            {
                return true;
            }
            return false;
        }
        static bool VerificarIfPosicaoFinal(int posicaoXAtual, int posicaoYAtual, int XM, int YM)
        {
            if (posicaoXAtual < 0 || posicaoYAtual < 0 || posicaoXAtual > XM || posicaoYAtual > YM)
            {
                return true;
            }
            return false;
        }
        static string AtribuirPosicaoFinalRobo(int posicaoXAtual, int posicaoYAtual, int XM, int YM, char DA)
        {
            if (VerificarIfPosicaoFinal(posicaoXAtual, posicaoYAtual, XM, YM))
            {
                return "Erro";
            }
            else
            {
                return  $"{posicaoXAtual} {posicaoYAtual} {DA}";
            }
        }
        static char MudarEixoDeDirecao(char DA, char[] movi, int i)
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
    }
}