namespace ToolkitSigma
{

    class Item4
    {
        public static void AvaliadorProposicional()
        {
            Console.WriteLine("4 - Avaliar proposições básicas");
            bool P = LerBooleano("Valor de P (true/false): ");
            bool Q = LerBooleano("Valor de Q (true/false): ");
            bool R = LerBooleano("Valor de R (true/false): ");

            Console.WriteLine("Fórmulas disponíveis:");
            Console.WriteLine("1 - (P ∧ Q) ∨ R");
            Console.WriteLine("2 - (P -> (Q ∨ R))  (implicação)");
            Console.Write("Escolha a fórmula (1/2): ");
            string? escolha = Console.ReadLine();
            bool resultado = false;
            if (escolha == "1")
            {
                resultado = (P && Q) || R;
                Console.WriteLine($"Resultado da fórmula (P ∧ Q) ∨ R: {resultado}");
            }
            else if (escolha == "2")
            {
                resultado = (!P) || (Q || R); // P -> (Q ∨ R) = ¬P ∨ (Q ∨ R)
                Console.WriteLine($"Resultado da fórmula P -> (Q ∨ R): {resultado}");
            }
            else
            {
                Console.WriteLine("Escolha inválida.");
            }

            Console.Write("Deseja imprimir a tabela-verdade completa da fórmula escolhida? (s/n): ");
            string? tab = (Console.ReadLine() ?? "").Trim().ToLower();
            if (tab == "s")
            {
                ImprimirTabelaVerdade(escolha);
            }
        }
        
        static bool LerBooleano(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? booleano = Console.ReadLine();
                if (string.IsNullOrEmpty(booleano)) continue;
                booleano = booleano.Trim().ToLower();
                if (booleano == "true" || booleano == "t" || booleano == "1") return true;
                if (booleano == "false" || booleano == "f" || booleano == "0") return false;
                Console.WriteLine("Entrada inválida. Digite 'true' ou 'false' (ou t/f ou 1/0).");
            }
        }

        static void ImprimirTabelaVerdade(string? escolha)
        {
            Console.WriteLine("Tabela verdade:");
            Console.WriteLine("P Q R | Resultado");
            // loops aninhados
            foreach (int p in new int[] { 0, 1 })
                foreach (int q in new int[] { 0, 1 })
                    foreach (int r in new int[] { 0, 1 })
                    {
                        bool P = p == 1; bool Q = q == 1; bool R = r == 1;
                        bool res = false;
                        if (escolha == "1") res = (P && Q) || R;
                        else if (escolha == "2") res = (!P) || (Q || R);
                        else res = false;
                        Console.WriteLine($"{(P ? "1" : "0")} {(Q ? "1" : "0")} {(R ? "1" : "0")} | {(res ? "1" : "0")}");
                    }
        }
    }
}