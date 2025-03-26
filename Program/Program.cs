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

            Console.Write("Qual o posicao inicial do robo? ");
            string pi = Console.ReadLine()!;
            string[] posicaoI = pi.Split(separadores);
            int XI = int.Parse(posicaoI[0]), YI = int.Parse(posicaoI[1]);
            char DA = char.Parse(posicaoI[2]);

            int posicaoXAtual = XI, posicaoYAtual = YI;

            Console.Write("Qual a movimentacao do robo(E, D ou M)? ");
            string movimentos = Console.ReadLine()!.ToUpper();
            char[] movi = movimentos.ToCharArray();



            for (int i = 0;i < movi.Length;i++)
            {
                if (movi[i] == 'E')
                {
                    if (DA == 'N')
                    {
                        DA = 'O';
                    }
                    else if (DA == 'O')
                    {
                        DA = 'S';
                    }
                    else if (DA == 'S')
                    {
                        DA = 'L';
                    }
                    else
                    {
                        DA = 'N';
                    }
                }
                else if (movi[i] == 'D')
                {
                    if (DA == 'N')
                    {
                        DA = 'L';
                    }
                    else if (DA == 'O')
                    {
                        DA = 'N';
                    }
                    else if (DA == 'S')
                    {
                        DA = 'O';
                    }
                    else
                    {
                        DA = 'S';
                    }
                }
                else if (movi[i] == 'M')
                {
                    if (DA == 'N')
                    {
                        posicaoYAtual++;
                    }
                    else if (DA == 'O')
                    {
                        posicaoXAtual--;
                    }
                    else if (DA == 'S')
                    {
                        posicaoYAtual--;
                    }
                    else
                    {
                        posicaoXAtual++;
                    }
                }
            }

            Console.WriteLine($"posicao final: {posicaoXAtual} {posicaoYAtual} {DA}");
            Console.ReadLine();
        }
    }
}