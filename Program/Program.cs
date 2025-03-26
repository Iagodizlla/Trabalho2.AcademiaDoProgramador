namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o tamanho da Grid(X e Y)? ");
            int X = int.Parse(Console.ReadLine()!);
            int Y = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Qual o posicao inicial do robo?");
            int Xinicial = int.Parse(Console.ReadLine()!);
            int Yinicial = int.Parse(Console.ReadLine()!);
            char ladoinicial = char.Parse(Console.ReadLine()!);

            Console.WriteLine("Qual a movimentacao do robo(E, D e M)?");
            string movi = Console.ReadLine()!;
        }
    }
}