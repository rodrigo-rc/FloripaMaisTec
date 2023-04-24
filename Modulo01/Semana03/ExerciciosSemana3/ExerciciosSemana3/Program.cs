using ExerciciosSemana3;
using ExerciciosSemana3.Enums;

ContaBancaria conta1 = new ContaBancaria(2708, 1234, "Rodrigo", TipoContaEnum.CORRENTE);
ContaBancaria conta2 = new ContaBancaria(2312, 1234, "João", TipoContaEnum.CORRENTE);

conta1.Depositar(200);

conta1.Transferir(conta2, 100);

conta1.ExibirSaldo();

conta2.ExibirSaldo();


Produto produto1 = new Produto();
produto1.Nome = "Calculadora";
produto1.VerificarEstoque();
Console.WriteLine("O nome do produto é: " + produto1.Nome);

ProdutoFinanceiro produtoFinanceiro = new ProdutoFinanceiro();
produtoFinanceiro.Nome = "Produto Financeiro";
produtoFinanceiro.VerificarEstoque();
produtoFinanceiro.Acesso();