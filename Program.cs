
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


BarraCarregamento("Carregando", 200);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

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
            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=================================================================================
*                                                                               *
*                            Escolha uma das Opções:                            *
*_______________________________________________________________________________*
*                                                                               *
*                              1 - Cadastrar Pessoa Física                      *
*                              2 - Mostrar Pessoa Física                        *
*                                                                               *
*                              0  - Sair                                        *
*                                                                               *
=================================================================================

");
                    opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da Pessoa Física a ser cadastrada: ");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento: ");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                            if (dataValida)
                            {
                                novaPf.DataNascimento = dataNasc;
                            }
                            else {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Digite uma data de nascimento válida: ");
                                Console.ResetColor();

                            }
                        } while (dataValida == false);


                        Console.WriteLine($"Digite o CPF: ");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Informe o valor do seu rendimento: ");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Informe o endereço:");
                        novoEnd.logradouro = Console.ReadLine();

                        Console.WriteLine($"Número: ");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Complemento ou Enter caso não possua: ");
                        novoEnd.Complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial ? S ou N ");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnd.endComercial = true;

                        }
                        else
                        {
                            novoEnd.endComercial = false;
                        }

                        novaPf.endereço = novoEnd;
                        listaPf.Add(novaPf);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso !!");
                        Thread.Sleep(4000);
                        Console.ResetColor();
                        break;



                    case "2":

                        Console.Clear();
                        if(listaPf.Count > 0){
                            foreach (PessoaFisica cadaPessoa in listaPf)

                            {   
                                Console.Clear();
                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Endereço: {cadaPessoa.endereço.logradouro}, {cadaPessoa.endereço.numero}
                                Data de Nascimento: {cadaPessoa.DataNascimento}
                                Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");      
                            Console.WriteLine ($"Digite Enter para continuar");
                            Console.ReadLine(); 

                            }

                        } else {
                            Console.WriteLine($"Lista Vazia !");
                            Thread.Sleep(3000);
                            
                        }
                        
                            break;

            case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida, favor digitar outra opção.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPf != "0");


            // PessoaFisica novaPf = new PessoaFisica();
            // Endereco novoEnd = new Endereco();

            // novaPf.nome = "Denise Souza";
            // novaPf.DataNascimento = "17/05/1982";
            // novaPf.cpf = "300.178.268-45";
            // novaPf.rendimento = 2000.0f;
            // novoEnd.logradouro = "Rua: Esmeraldo Tarquinio";
            // novoEnd.numero = 184;
            // novoEnd.Complemento = "casa";
            // novoEnd.endComercial = true;
            // novaPf.endereço = novoEnd;

            // Console.WriteLine(@$"
            // Nome: {novaPf.nome}
            // Endereço: {novaPf.endereço.logradouro}, {novaPf.endereço.numero}
            // Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.DataNascimento) ? "Sim" : "Não")}
            // Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
            // ");           


            // Console.WriteLine ($"Digite Enter para continuar");
            // Console.ReadLine();

            break;


        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndpj = new Endereco();
            novaPj.nome = "HShop";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "DC Souza Comercial";
            novaPj.rendimento = 600.0f;
            novoEndpj.logradouro = "Rua: Esmeraldo Tarquinio";
            novoEndpj.numero = 184;
            novoEndpj.Complemento = "casa";
            novoEndpj.endComercial = true;


            Console.WriteLine($@"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj}
            CNPJ é valido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}
            O valor do imposto é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");


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


