class Conta
{
    public string Titular { get; set; }
    public int IdConta { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }

    public void exibirInformacoes()
    {
        Console.WriteLine("\nINFORMAÇÕES DA CONTA:");
        Console.WriteLine($"Titular: {this.Titular}");
        Console.WriteLine($"Saldo atual: {this.Saldo}");
    }
}
