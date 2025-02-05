// Classe Conta que representa uma conta bancária, com atributos Titular, agência, número da conta, saldo e limite.  
// Inclui um método que retorna as informações detalhadas da conta.  
Conta conta = new Conta();
conta.Titular = "Gui Lima";
conta.IdConta = 1;
conta.Saldo = 20.00f;
conta.Senha = 1234;

Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {conta.Titular}");
Console.WriteLine($"Saldo atual: {conta.Saldo}");

conta.exibirInformacoes();