namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o tamanho da Grid(X e Y)? ");
            string tg = Console.ReadLine()!;
            char[] separadores = { ' ' };
            string[] grid = tg.Split(separadores);
            int XM = int.Parse(grid[0]), YM = int.Parse(grid[1]);

            string robo1 = "", robo2 = "";

            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Qual o posicao inicial do robo {j+1}? ");
                string pi = Console.ReadLine()!;
                string[] posicaoI = pi.Split(separadores);
                int XI = int.Parse(posicaoI[0]), YI = int.Parse(posicaoI[1]);
                char DA = char.Parse(posicaoI[2].ToUpper());
                int posicaoXAtual = XI, posicaoYAtual = YI;

                Console.Write("Qual a movimentacao do robo(E, D ou M)? ");
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

            Console.WriteLine($"posicao final robo 1: {robo1}");
            Console.WriteLine($"posicao final robo 2: {robo2}");
            Console.ReadLine();
        }
    }
}