namespace ToolkitSigma
{
    class Item8
    {
        public static void ReconhecedorNaoTermina()
        {
            Console.WriteLine("\nAV2: 8 - Demonstrar reconhecedor que pode não terminar");

            Console.WriteLine("Linguagem reconhecível: L = { w | w em {a,b}* e começa com 'a' }");
            Console.WriteLine("Descrição: Um reconhecedor que ACEITA se w começa com 'a',");
            Console.WriteLine("mas entra em LOOP INFINITO (não termina) se w começa com 'b'.");

            Console.Write("\nDigite uma cadeia (apenas a/b): ");
            string? cadeia = Console.ReadLine() ?? "";

            foreach (char c in cadeia)
            {
                if (c != 'a' && c != 'b')
                {
                    Console.WriteLine("Cadeia inválida: símbolo fora de Σ.");
                    Console.WriteLine();
                    return;
                }
            }

            int limitePassos = 0;
            while (limitePassos <= 0)
            {
                Console.Write("Digite o limite de passos para abortar (ex: 1000): ");
                int.TryParse(Console.ReadLine(), out limitePassos);
                if (limitePassos <= 0) Console.WriteLine("Valor inválido.");
            }

            Console.WriteLine($"Iniciando execução (limite de {limitePassos} passos)...");

            if (string.IsNullOrEmpty(cadeia))
            {
                Console.WriteLine("\nREJEITA (Cadeia vazia)");
                Console.WriteLine();
                return;
            }

            if (cadeia[0] == 'a')
            {
                Console.WriteLine("Cadeia começa com 'a'.");
                Console.WriteLine("\nACEITA");
                Console.WriteLine();
                return;
            }

            if (cadeia[0] == 'b')
            {
                Console.WriteLine("Cadeia começa com 'b'. Entra em loop infinito...");
                int passoAtual = 0;
                while (true)
                {
                    passoAtual++;
                    Console.WriteLine($"Passo {passoAtual}: Processando...");

                    if (passoAtual >= limitePassos)
                    {
                        Console.WriteLine($"\nINTERROMPIDO (limite de {limitePassos} passos atingido)");
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}