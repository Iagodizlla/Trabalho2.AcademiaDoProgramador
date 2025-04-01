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
                #region Variaveis
                bool erro = false;
                char[] separadores = {' '}, movi;
                int XM, YM;
                string[] grid, posicaoI;
                char m;
                string robo1 = "", robo2 = "";
                LogicaRobo robo = new LogicaRobo(); 
                #endregion
                #region Exibir menu inicial
                m = Exibicao.ExibirMenu();
                #endregion
                #region Sair do console
                if (m == '0')
                {
                    break;
                }
                #endregion
                #region Fazer simulacao
                else if (m == '1')
                {
                    while (true)
                    {
                        grid = PerguntasUsuario.PerguntarTamanhoGrid(separadores);
                        #region Verifica erro e atrbui valor
                        Verificadores.VerificarArrayGrid(grid, ref erro);

                        if (erro)
                        {
                            continue;
                        }
                        XM = int.Parse(grid[0]);
                        YM = int.Parse(grid[1]);
                        break;
                        #endregion
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        posicaoI = PerguntasUsuario.PerguntarPosicaoInicial(separadores, j);
                        #region Verifica erro e atrbui valor
                        Verificadores.VerificarArrayPosicaoInicial(posicaoI, ref erro);

                        if (erro)
                        {
                            j--;
                            continue;
                        }
                        robo.posicaoXAtual = int.Parse(posicaoI[0]);
                        robo.posicaoYAtual = int.Parse(posicaoI[1]);
                        robo.DA = char.Parse(posicaoI[2].ToUpper());
                        if (Verificadores.VerificarIfPosicaoInicial(robo.posicaoXAtual, robo.posicaoYAtual, XM, YM, robo.DA))
                        {
                            Console.WriteLine("Posicao inicial invalida");
                            j--;
                            continue;
                        }
                        #endregion
                        movi = PerguntasUsuario.PerguntarMovimentacao();
                        #region Verifica erro e atrbui valor
                        Verificadores.VerificarArrayMovimentacao(movi, ref erro);

                        if(erro)
                        {
                            j--;
                            continue;
                        }
                        #endregion
                        #region Logica do robo
                        for (int i = 0; i < movi.Length; i++)
                        {
                            robo.MudarEixoDeDirecao(movi, i);
                            if (movi[i] == 'M')
                            {
                                robo.AlterarDirecaoX();
                                robo.AlterarDirecaoY();
                            }
                        }
                        #endregion
                        #region Atribuir posicao final do robo
                        if (j == 0)
                        {
                            robo1 = Exibicao.AtribuirPosicaoFinalRobo(robo.posicaoXAtual, robo.posicaoYAtual, XM, YM, robo.DA);
                        }
                        else
                        {
                            robo2 = Exibicao.AtribuirPosicaoFinalRobo(robo.posicaoXAtual, robo.posicaoYAtual, XM, YM, robo.DA);
                        }
                        #endregion
                    }
                    Exibicao.ExibirRespostaFinal(robo1, robo2);
                }
                #endregion
                #region Mostrar turorial
                else if (m == '2')
                {
                    Exibicao.ExibirTutorial();
                }
                #endregion
                #region Opcao invalida
                else
                {
                    Exibicao.ExibirOpcaoMenuInvalido();
                }
                #endregion
            }
        }
    }
}