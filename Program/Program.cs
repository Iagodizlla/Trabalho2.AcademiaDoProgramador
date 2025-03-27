using System.Xml;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|        * Robô Tupiniquim    *     *|");
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("|               MENU                 |");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|              Sair - 0              |");
                Console.WriteLine("|            Utilizar - 1            |");
                Console.WriteLine("|            Tutorial - 2            |");
                Console.WriteLine("--------------------------------------");
                byte m = byte.Parse(Console.ReadLine()!);

                if(m == 0)
                {
                    break;
                }
                else if (m == 1)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("|        * Robô Tupiniquim    *     *|");
                    Console.WriteLine("--------------------------------------");

                    Console.Write("\nQual o tamanho da Grid(X e Y)? ");
                    string tg = Console.ReadLine()!;
                    char[] separadores = { ' ' };
                    string[] grid = tg.Split(separadores);
                    int XM = int.Parse(grid[0]), YM = int.Parse(grid[1]);

                    string robo1 = "", robo2 = "";

                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine($"Qual o posicao inicial do robo {j + 1}? ");
                        string pi = Console.ReadLine()!;
                        string[] posicaoI = pi.Split(separadores);
                        int XI = int.Parse(posicaoI[0]), YI = int.Parse(posicaoI[1]);
                        char DA = char.Parse(posicaoI[2].ToUpper());
                        int posicaoXAtual = XI, posicaoYAtual = YI;

                        Console.WriteLine("Qual a movimentacao do robo(E, D ou M)? ");
                        string movimentos = Console.ReadLine()!.ToUpper();
                        char[] movi = movimentos.ToCharArray();

                        for (int i = 0; i < movi.Length; i++)
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
                            else if (movi[i] == 'M')
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
                            robo1 = $"{posicaoXAtual} {posicaoYAtual} {DA}";
                        }
                        else
                        {
                            robo2 = $"{posicaoXAtual} {posicaoYAtual} {DA}";
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("|        * Robô Tupiniquim    *     *|");
                    Console.WriteLine("--------------------------------------");

                    Console.WriteLine($"\nposicao final robo 1: {robo1}");
                    Console.WriteLine($"posicao final robo 2: {robo2}");
                    Console.ReadLine();
                }
                else if (m == 2)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("|        * Robô Tupiniquim    *     *|");
                    Console.WriteLine("--------------------------------------");

                    Console.WriteLine("\nComo digitar corretamente a Grid inicial:\n" +
                        "- A grid inicial é basicamnete o plano cartesiano, só que sem a parte das numeros negativos.\n" +
                        "- Ela é formada pelos eixos X e Y, onde X é a horizontal e Y a vertical.\n" +
                        "- Na hora de escrever o tamanho da grid no console, digite: (numero | espaço | numero).\n" +
                        "- Exemplo: 20 40.\n");
                    Console.WriteLine("Como digitar corretamente a posicao inicial do robo:\n" +
                        "- Primeiro se digita em que posicao na grid ele esta, igual falamos no tutorial anterior.\n" +
                        "- Segunda parte é pra que lado ele está virado Norte(N), Oeste(O), Sul(S) ou Letse(L).\n" +
                        "- Na hora de escrever isso no console, digite: (numero | espaço | numero | espaço | letra).\n" +
                        "- Exemplo: 5 8 N.\n");
                    Console.WriteLine("Como digitar corretamente a movimentacao do robo:\n" +
                        "- Temos três(3) opções de movimentação, Esquerdo(E), Direito(D) e Medio(M).\n" +
                        "- As opções E e D, são para o robo virar para o lado, ele não se move de lugar, somente gira no próprio eixo.\n" +
                        "- A opção M só se move um espaço para frente de forma reta, sem poder se mexer pros lados.\n" +
                        "- A quantidade de comandos de uma só vez é praticamente ilimitada, podendo ir de 1 comando a 50 se quiser.\n" +
                        "- Na hora de escrever isso no console, digite: (letra | letra | letra...     ... letra | letra).\n" +
                        "- Exemplo: EMEMMDDMMM");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opcao invalida");
                }
            }
        }
    }
}