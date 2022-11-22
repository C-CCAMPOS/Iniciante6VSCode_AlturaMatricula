
Console.WriteLine("********************************");
Console.WriteLine(">>>> PROGRAMA PARA INFORMAR <<<<");
Console.WriteLine("********************************");
Console.WriteLine("   |- A MATRICULA DO ALUNO |");
Console.WriteLine("   |- A ALTURA DO ALUNO    |");
Console.WriteLine("   |- O ALUNO MAIS ALTO    |");
Console.WriteLine("   |- O ALUNO MAIS BAIXO   |");
Console.WriteLine("********************************\n");

int i = 1;
int qtd = 0;
int matricula = 0;
int maiorMatricula = 0;
int menorMatricula = 0;
double altura = 0;
double maiorAltura = 0;
double menorAltura = 0;

Console.Write("\n\n\nDigite a quantidade de Alunos da lista: ");
qtd = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("*******************************************************************\n\n");

Console.Write("|1| Informe a Matricula do Aluno: ");
matricula = Convert.ToInt32(Console.ReadLine());

Console.Write("       Informe a Altura do Aluno: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("**************************************");

maiorMatricula = matricula;
menorMatricula = matricula;
maiorAltura = altura;
menorAltura = altura;

while(i < qtd)
{
    i++;

    Console.Write("|{0}| Informe a Matricula do Aluno: ", i);
    matricula = Convert.ToInt32(Console.ReadLine());

    Console.Write("       Informe a Altura do Aluno: ");
    altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("**************************************");

    if(maiorAltura < altura)
    {
        maiorAltura = altura;
        maiorMatricula = matricula;
    }

    if(menorAltura > altura)
    {
        menorAltura = altura;
        menorMatricula = matricula;
    }
}
Console.WriteLine("\n\n*******************************************************************");
Console.WriteLine("O aluno mais alto é o de matricula |{0}| com |{1} cm| de altura.", maiorMatricula, maiorAltura);
Console.WriteLine("*******************************************************************");
Console.WriteLine("O aluno mais baixo é o de matricula |{0}| com |{1} cm| de altura.", menorMatricula, menorAltura);
Console.WriteLine("*******************************************************************");

Console.ReadKey();
Console.Clear();

Console.WriteLine("\n\n\n*******************************************************************");
Console.WriteLine(">>>>>>>>         APLICAÇÃO FINALIZADA COM SUCESSO!         <<<<<<<<");
Console.WriteLine("*******************************************************************");
Console.ReadKey();
