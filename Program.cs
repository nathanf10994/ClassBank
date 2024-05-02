using ClassBank.Menu;

namespace ClassBank;
   
public class Program
{

    private static Dictionary <int, Correntista> contasDoBanco = new();

    public static void Main()
    {
        
        Dictionary <int, MenuDeOpcoes> opcoesDoMenu = new();
        opcoesDoMenu.Add(1, new MenuAdicionarCorrentista());
        opcoesDoMenu.Add(2, new MenuRealizarDeposito());
        opcoesDoMenu.Add(3, new MenuRealizarSaque());
        opcoesDoMenu.Add(4, new MenuRealizarTransferencia());
        opcoesDoMenu.Add(5, new MenuConsultarSaldo());
        opcoesDoMenu.Add(0, new MenuSaidaDoPrograma());

        int opcaoInformada;
        
        
        try
        {
            opcaoInformada = MenuDeOpcoes.Index();

            if (opcoesDoMenu.ContainsKey(opcaoInformada))
            {
                MenuDeOpcoes opcaoEscolhida = opcoesDoMenu[opcaoInformada];
                opcaoEscolhida.Executar(contasDoBanco);
                if (opcaoInformada != 0) Main();
            }
            else
            {
                throw new Exception();
            }
        }
        catch
        {
            MenuDeOpcoes opcaoInvalida = new MenuOpcaoInvalida();
            opcaoInvalida.Executar(contasDoBanco);
            Main();
        }
    }
}
