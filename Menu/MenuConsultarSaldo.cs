namespace ClassBank.Menu;

internal class MenuConsultarSaldo : MenuDeOpcoes
{
    public override void Executar (Dictionary<int, Correntista> contas)
    {
        base.Executar (contas);
        try
        {
            Console.Write("Informe o Código de sua conta -> ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Clear();
            contas[numeroConta].Saldo();
            PressionarTecla();
        }
        catch
        {
            Erro();
        }
        
    }
}
