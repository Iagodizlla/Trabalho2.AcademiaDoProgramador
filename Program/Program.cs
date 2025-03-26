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
            char LI = char.Parse(posicaoI[2]);

            Console.Write("Qual a movimentacao do robo(E, D e M)? ");
            string movimentos = Console.ReadLine()!.ToUpper();
            char[] movi = movimentos.ToCharArray();

            for (int i = 0; i < movi.Length; i++)
            {
                Console.WriteLine($"Movimento {i}: {movi[i]}");
            }
            Console.WriteLine($"posicao inicial: {XI}, {YI}, {LI}");
            Console.WriteLine($"grid: {XM}, {YM}");
            Console.ReadLine();
        }
    }
}