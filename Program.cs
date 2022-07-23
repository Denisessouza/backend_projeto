
using backend_projeto;
using backend_projeto.classes;

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


// //*
// Console.WriteLine(novaPf.nome);
// Console.WriteLine("Nome: " + novaPf.nome); //Concatenado
// Console.WriteLine($"Nome: {novaPf.nome}");  //Interpolado
// */



// Console.WriteLine(novaPf.ValidarDataNascimento("1982,05,17"));



PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndpj = new Endereco();

novaPj.nome ="HShop";
novaPj.cnpj ="00.000.000/0001-00";
novaPj.razaoSocial="DC Souza Comercial";
novaPj.rendimento= 600;

novoEndpj.logradouro="Rua: Esmeraldo Tarquinio";
novoEndpj.numero= 184;
novoEndpj.Complemento="casa";
novoEndpj.endComercial= true;


Console.WriteLine($@"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");


