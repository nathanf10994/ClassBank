namespace ClassBank.Menu;

internal class MenuSaidaDoPrograma : MenuDeOpcoes
{
    public override void Executar(Dictionary<int, Correntista> contas)
    {
        base.Executar(contas);
        Console.WriteLine("Obrigado por utilizar os serviços do ClassBank!");
        Console.WriteLine("Tenha um ótimo dia!");
    }
}
