namespace Aula_dia_22_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem Vindo à Escola de Programação Software Tech");

            do
            {
                // Aqui começamos o loop do-while para permitir várias entradas de aluno

                string nome = ObterDado("nome");
                string sobrenome = ObterDado("sobrenome");
                int idade = ObterIdade();

                int nota1 = ObterNota("primeira");
                int nota2 = ObterNota("segunda");
                int media = CalcularMedia(nota1, nota2);

                List<string> disciplinas = ObterDisciplinas();

                Dictionary<string, object> aluno = new Dictionary<string, object>
                {
                    { "Nome", nome },
                    { "Sobrenome", sobrenome },
                    { "Idade", idade },
                    { "Nota-1", nota1 },
                    { "Nota-2", nota2 },
                    { "Media", media },
                    { "Disciplinas", disciplinas }
                };

                ExibirDadosDoAluno(aluno);
                VerificarAprovacao(media);

            } while (Continuar()); // Aqui verificamos se o usuário deseja continuar

            Console.WriteLine("Programa finalizado. Obrigado por usar!");
        }

        static string ObterDado(string dado)
        {
            Console.Write($"Digite seu {dado}: ");
            return Console.ReadLine();
        }

        static int ObterIdade()
        {
            Console.Write("Digite sua idade: ");
            return int.Parse(Console.ReadLine());
        }

        static int ObterNota(string numero)
        {
            Console.Write($"Digite a {numero} nota: ");
            return int.Parse(Console.ReadLine());
        }

        static int CalcularMedia(int nota1, int nota2)
        {
            return (nota1 + nota2) / 2;
        }

        static List<string> ObterDisciplinas()
        {
            Console.WriteLine("Digite suas disciplinas separadas por vírgula (por exemplo: Matemática, Português): ");
            string disciplinasInput = Console.ReadLine();
            string[] disciplinasArray = disciplinasInput.Split(',');

            return new List<string>(disciplinasArray);
        }

        static void ExibirDadosDoAluno(Dictionary<string, object> aluno)
        {
            Console.WriteLine("Dados do Aluno:");
            foreach (var kvp in aluno)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        static void VerificarAprovacao(int media)
        {
            bool aprovado = media >= 7;
            Console.WriteLine("Aprovado: " + aprovado);
        }

        static bool Continuar()
        {
            Console.Write("Deseja continuar? (s/n): ");
            string resposta = Console.ReadLine().ToLower();

            return resposta == "s";
        }
    }
    }
}