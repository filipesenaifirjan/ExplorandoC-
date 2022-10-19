using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Filipe","Assunção");
//p1.Nome = "Filipe"; //"Filipe";
//p1.Sobrenome = "Assunção";

Pessoa p2 = new Pessoa();
p2.Nome = "Fil"; //"Filipe";
p2.Sobrenome = "Mattos";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

    cursoDeIngles.AdicionarAluno(p1);
    cursoDeIngles.AdicionarAluno(p2);
    cursoDeIngles.ListarAlunos();









//Pessoa p1 = new Pessoa();
//p1.Nome = "Filipe"; //"Filipe";
//p1.Sobrenome = "Assunção";
//p1.Idade = 19;
//p1.Apresentar();