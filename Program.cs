using Propriedades__Métodos_e_Construtores.Model;

Pessoa p1 = new Pessoa(Nome:"Leandresson",Sobrenome:"Fulco");


Pessoa p2 = new Pessoa(Nome:"Cleiton",Sobrenome:"Moreira");


Curso logicaEalgoritmo = new Curso();

logicaEalgoritmo.Nome = "Logica e Algoritmo em C";
logicaEalgoritmo.Alunos = new List<Pessoa>();


Console.WriteLine($"Alunos do curso de: {logicaEalgoritmo.Nome}");
logicaEalgoritmo.AdicionarAluno(p2);
logicaEalgoritmo.AdicionarAluno(p1);


logicaEalgoritmo.ListarAlunos();