using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

//CalucularBonificacao();
UsarSistema();


void CalucularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    Designer pedro = new Designer("833.222.045-21");
    pedro.Nome = "Pedro";

    Desenvolvedor joao = new Desenvolvedor("498.647.921-25");
    joao.Nome = "João";

    Diretor paula = new Diretor("548.697.212-65");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("171.654.988-32");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("987.125.645-04");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(joao);

    Console.WriteLine("Total de Bonificação: " + gerenciador.GetBonificacao());

}

void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor vanessa = new Diretor("654.021.365-12");
    vanessa.Nome = "Vanessa";
    vanessa.Senha = "2323";

    GerenteDeContas fabiana = new GerenteDeContas("656.432.147-98");
    fabiana.Nome = "Fabiana";
    fabiana.Senha = "0639";

    //Funcionario fernando = new Designer("079.613.348-32");
    // fernando.Nome = "Fernando";
    // fernando.Senha = "3687";

    ParceiroComercial lucas = new ParceiroComercial();
    lucas.Senha = "0000";

    sistemainterno.Logar(lucas, "0000");
    sistemainterno.Logar(vanessa, "2623");
    sistemainterno.Logar(fabiana, "0639");
    //sistemainterno.Logar(fernando, "3687");
}


Console.ReadKey();  