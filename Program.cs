﻿using backend_projeto;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Denise";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome); //Concatenado
Console.WriteLine($"Nome: {novaPf.nome}");  //Interpolado



