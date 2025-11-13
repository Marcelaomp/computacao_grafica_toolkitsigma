namespace ToolkitSigma
{
    class Item9
    {
        public static void DetectorLoopIngenuo()
        {
            Console.WriteLine("\nAV2: 9 - Utilizar detector ingênuo de loop + reflexão");

            Console.WriteLine("Processo discreto: Função matemática simples (ex: (n * 7 + 1) % 50)");

            int numeroAtual = -1;
            while (numeroAtual < 0)
            {
                Console.Write("Digite um número inteiro positivo inicial (ex: 5): ");
                int.TryParse(Console.ReadLine(), out numeroAtual);
                if (numeroAtual < 0) Console.WriteLine("Entrada inválida.");
            }

            int limitePassos = 0;
            while (limitePassos <= 0)
            {
                Console.Write("Digite o limite de passos da simulação (ex: 100): ");
                int.TryParse(Console.ReadLine(), out limitePassos);
                if (limitePassos <= 0) Console.WriteLine("Valor inválido.");
            }

            List<int> historicoEstados = new List<int>();
            int passoAtual = 0;
            bool loopDetectado = false;

            while (passoAtual < limitePassos && !loopDetectado)
            {
                passoAtual++;
                Console.WriteLine($"Passo {passoAtual}: Estado = {numeroAtual}");

                if (historicoEstados.Contains(numeroAtual))
                {
                    Console.WriteLine($"\nLOOP DETECTADO (estado {numeroAtual} já foi visto)");
                    loopDetectado = true;
                }
                else
                {
                    historicoEstados.Add(numeroAtual);
                    numeroAtual = (numeroAtual * 7 + 1) % 50;
                }
            }

            if (passoAtual >= limitePassos && !loopDetectado)
            {
                Console.WriteLine($"\nINTERROMPIDO (limite de {limitePassos} passos atingido).");
            }

            Console.WriteLine("\n--- Reflexão sobre o Detector Simples de Loop ---");
            Console.WriteLine("1. Falsos Positivos: A heurística pode indicar um loop mesmo quando não há erro,");
            Console.WriteLine("   apenas um ciclo que eventualmente termina.");
            Console.WriteLine("2. Falsos Negativos: Se o loop for muito grande ou crescer sem repetir estados,");
            Console.WriteLine("   a heurística pode não detectar o problema.");
            Console.WriteLine("3. Problema da Parada: Não existe uma forma de saber se qualquer programa vai parar");
            Console.WriteLine("   ou entrar em loop para qualquer entrada. A heurística é só uma forma aproximada de detectar isso.");
            Console.WriteLine();

        }
    }
}