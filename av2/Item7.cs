namespace ToolkitSigma
{
    class Item7
    {
        public static void Decisor()
        {
            Console.WriteLine("AV2: 7 - Decidir Σ={a,b}: L_fim_b e L_mult3_b");
            Console.Write("Digite uma cadeia (apenas a/b): ");
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

            Console.WriteLine("Escolha o decisor:");
            Console.WriteLine("1 - L_fim_b (cadeias que terminam com 'b')");
            Console.WriteLine("2 - L_mult3_b (cadeias com número de 'b's múltiplo de 3)");
            Console.Write("Opção: ");
            string? opcao = Console.ReadLine();

            if (opcao == "1")
            {
                bool terminaComB = cadeia.EndsWith('b');
                Console.WriteLine(terminaComB ? "SIM" : "NAO");
            }
            else if (opcao == "2")
            {
                int contadorB = 0;
                foreach (char c in cadeia)
                    if (c == 'b') contadorB++;

                bool multiploDe3 = contadorB % 3 == 0;
                Console.WriteLine(multiploDe3 ? "SIM" : "NAO");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
            Console.WriteLine();
        }
    }
}