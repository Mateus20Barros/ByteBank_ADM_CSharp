using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System.Linq.Expressions;

#region
//Funcionario pedro = new Funcionario("Pedro", "123456789", 2000);
//Funcionario roberta = new Diretor("Roberta", "987654321");

//Console.WriteLine($"{pedro.Nome} -> Bonificação.: {pedro.GetBonificacao():C}");
//Console.WriteLine($"{roberta.Nome} -> Bonificação.: {roberta.GetBonificacao():C}");

//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.registrar(pedro);
//gerenciador.registrar(roberta);

//Console.WriteLine($"\nTotal bonificacao.: {gerenciador.totalBonificacao}");
//Console.WriteLine($"Total Funcionarios.: {Funcionario.TotalFuncionarios}");

//Console.WriteLine($"\nSalario Inicial Pedro.: {pedro.Salario}\nSalario Inicial Roberta.: {roberta.Salario}\n");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo Salario Pedro.: {pedro.Salario}\nNovo Salario Roberta.: {roberta.Salario}");
#endregion

static void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer ulisses = new Designer("Ulisses Souza", "1234");
    Diretor paula = new Diretor("Paula Silva", "4321");
    Auxiliar igor = new Auxiliar("Igor Pereira", "5678");
    GerenteDeContas camila = new GerenteDeContas("Camila Dias", "8765");

    gerenciador.registrar(ulisses);
    gerenciador.registrar(paula);
    gerenciador.registrar(igor);
    gerenciador.registrar(camila);

    Console.WriteLine($"Total Bonificacao.: {gerenciador.totalBonificacao}");
}

//CalcularBonificacao();

UsarSistema();

static void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("Ingrid Novaes", "845102");
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("Ursula Alcantara","987654");
    ursula.Senha = "1234";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "456";


    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "1234");
    sistema.Logar(caio, "123");
}