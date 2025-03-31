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
                int XM, YM, posicaoXAtual, posicaoYAtual;
                string[] grid, posicaoI;
                char m, DA;
                string robo1 = "", robo2 = "";
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
                        erro = Verificadores.VerificarArrayGrid(grid, erro);

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
                        erro = Verificadores.VerificarArrayPosicaoInicial(posicaoI, erro);

                        if (erro)
                        {
                            j--;
                            continue;
                        }
                        posicaoXAtual = int.Parse(posicaoI[0]);
                        posicaoYAtual = int.Parse(posicaoI[1]);
                        DA = char.Parse(posicaoI[2].ToUpper());
                        if (Verificadores.VerificarIfPosicaoInicial(posicaoXAtual, posicaoYAtual, XM, YM, DA))
                        {
                            Console.WriteLine("Posicao inicial invalida");
                            j--;
                            continue;
                        }
                        #endregion
                        movi = PerguntasUsuario.PerguntarMovimentacao();
                        #region Verifica erro e atrbui valor
                        erro = Verificadores.VerificarArrayMovimentacao(movi, erro);

                        if(erro)
                        {
                            j--;
                            continue;
                        }
                        #endregion
                        #region Logica do robo
                        for (int i = 0; i < movi.Length; i++)
                        {
                            DA = LogicaRobo.MudarEixoDeDirecao(DA, movi, i);
                            if (movi[i] == 'M')
                            {
                                posicaoXAtual = LogicaRobo.AlterarDirecaoX(DA, posicaoXAtual);
                                posicaoYAtual = LogicaRobo.AlterarDirecaoY(DA, posicaoYAtual);
                            }
                        }
                        #endregion
                        #region Atribuir posicao final do robo
                        if (j == 0)
                        {
                            robo1 = Exibicao.AtribuirPosicaoFinalRobo(posicaoXAtual, posicaoYAtual, XM, YM, DA);
                        }
                        else
                        {
                            robo2 = Exibicao.AtribuirPosicaoFinalRobo(posicaoXAtual, posicaoYAtual, XM, YM, DA);
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