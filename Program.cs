
using backend_projeto;
using backend_projeto.classes;

Console.WriteLine(@$"
=================================================================================
*                                                                               *
*                              Seja Bem Vindo !                                 *
*               Sistema de Cadastro de Pessoas Físicas e Jurídicas              *
*                                                                               *
=================================================================================


");


BarraCarregamento("Carregando",200);

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=================================================================================
*                                                                               *
*                            Escolha uma das Opções:                            *
*_______________________________________________________________________________*
*                                                                               *
*                              1 - Pessoa Física                                *
*                              2 - Pessoa Jurídica                              *
*                                                                               *
*                              0  - Sair                                        *
*                                                                               *
=================================================================================

");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();
            PessoaFisica metodoPf = new PessoaFisica();
            novaPf.nome = "Denise Souza";
            novaPf.DataNascimento = "17/05/1982";
            novaPf.cpf = "300.178.268-45";
            novaPf.rendimento = 600.0f;
            novoEnd.logradouro = "Rua: Esmeraldo Tarquinio";
            novoEnd.numero = 184;
            novoEnd.Complemento = "casa";
            novoEnd.endComercial = true;
            novaPf.endereço = novoEnd;

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novaPf.endereço.logradouro}, {novaPf.endereço.numero}
            Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.DataNascimento)}");
            Console.WriteLine($"Digite Enter para sair");
            Console.ReadLine();

            break;


        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndpj = new Endereco();
            novaPj.nome = "HShop";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "DC Souza Comercial";
            novaPj.rendimento = 600;
            novoEndpj.logradouro = "Rua: Esmeraldo Tarquinio";
            novoEndpj.numero = 184;
            novoEndpj.Complemento = "casa";
            novoEndpj.endComercial = true;


            Console.WriteLine($@"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj}
            CNPJ é valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");

            Console.WriteLine($"Digite Enter para sair");
            Console.ReadLine();
            break;

        case "0":
            Console.WriteLine($"Obrigada por utilizar nosso Sistema");
            BarraCarregamento("Finalizando", 300);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida - Digite outra Opção");
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.DarkBlue;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 35; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(250);
    }

    Console.ResetColor();
}





// // BarraCarregamento - Metodo
// Console.BackgroundColor = ConsoleColor.Yellow;
//             // Console.ForegroundColor = ConsoleColor.DarkBlue;
//             // Console.Write($"Finalizando ");

//             // for (var contador = 0; contador < 35; contador++)
//             // {
//             //     Console.Write("♥ ");
//             //     Thread.Sleep(500);
//             // }

//             // Console.ResetColor();
//             // Console.ReadLine();














// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEnd = new Endereco();

// PessoaFisica metodoPf = new PessoaFisica();

// novaPf.nome ="Denise Souza";
// novaPf.DataNascimento="17/05/1982";
// novaPf.cpf ="300.178.268-45";
// novaPf.rendimento= 600.0f;
// novoEnd.logradouro="Rua: Esmeraldo Tarquinio";
// novoEnd.numero= 184;
// novoEnd.Complemento="casa";
// novoEnd.endComercial= true;

// novaPf.endereço= novoEnd;

// Console.WriteLine(@$"
//     Nome: {novaPf.nome}
//     Endereço: {novaPf.endereço.logradouro}, {novaPf.endereço.numero}
//     Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.DataNascimento)}
// ");



// Console.WriteLine(novaPf.nome);
// Console.WriteLine("Nome: " + novaPf.nome); //Concatenado
// Console.WriteLine($"Nome: {novaPf.nome}");  //Interpolado




// Console.WriteLine(novaPf.ValidarDataNascimento("1982,05,17"));



// PessoaJuridica metodoPj = new PessoaJuridica();
// PessoaJuridica novaPj = new PessoaJuridica();
// Endereco novoEndpj = new Endereco();

// novaPj.nome ="HShop";
// novaPj.cnpj ="00.000.000/0001-00";
// novaPj.razaoSocial="DC Souza Comercial";
// novaPj.rendimento= 600;

// novoEndpj.logradouro="Rua: Esmeraldo Tarquinio";
// novoEndpj.numero= 184;
// novoEndpj.Complemento="casa";
// novoEndpj.endComercial= true;


// Console.WriteLine($@"
// Nome: {novaPj.nome}
// Razão Social: {novaPj.razaoSocial}
// CNPJ: {novaPj.cnpj}
// CNPJ é valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");


