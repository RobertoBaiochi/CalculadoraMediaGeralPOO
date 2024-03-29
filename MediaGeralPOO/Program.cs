using System.Globalization;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "# Calcular Media Total #";

            Console.Write("Digite a Quantidade de Alunos: ");
            int nAlunos = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Digite o Nome do Aluno #" + (i + 1) + ": ");
                string nome = Console.ReadLine();

                Console.Write("Digite a quantidade de Provas do Aluno #" + (i + 1) + ": ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Digite as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Nome: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media.ToString("F2", CultureInfo.InvariantCulture));

                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("A media geral é: " + resultadoFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
