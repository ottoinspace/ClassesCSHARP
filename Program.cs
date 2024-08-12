using ExemploExplorando.Models;

Curso ads = new Curso();
ads.Nome = "Analise e desenvolvimento de sistemas";
ads.Alunos = new List<Pessoa>();

Pessoa p1 = new Pessoa();
p1.Nome = "Otto";
p1.Sobrenome = "Pine";

Pessoa p2 = new Pessoa();
p1.Nome = "Lina";
p1.Sobrenome = "Pine";

Pessoa p3 = new Pessoa();
p1.Nome = "Robertinho";
p1.Sobrenome = "Carlos";

Pessoa p4 = new Pessoa();
p1.Nome = "Haru";
p1.Sobrenome = "Hina";

ads.AdicionarAluno(p1);
ads.AdicionarAluno(p2);

ads.ListarAlunos();