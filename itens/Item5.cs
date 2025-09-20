namespace ToolkitSigma
{

    class Item5
    {
        public static void Reconhecedor()
        {
            Console.WriteLine("5 - Reconhecer Σ={a,b}: L_par_a e a b*");
            Console.Write("Digite uma cadeia (apenas a/b): ");
            string? cadeia = Console.ReadLine() ?? "";
            foreach (char c in cadeia)
            {
                if (c != 'a' && c != 'b')
                {
                    Console.WriteLine("Cadeia inválida: símbolo fora de Σ.");
                    return;
                }
            }
            Console.WriteLine("Escolha a linguagem:");
            Console.WriteLine("1 - L_par_a (número par de 'a')");
            Console.WriteLine("2 - L = { w | w = a b* } (começa com 'a' seguido só de b's)");
            Console.Write("Opção: ");
            string? opcao = Console.ReadLine();
            if (opcao == "1")
            {
                int countA = 0;
                foreach (char c in cadeia) if (c == 'a') countA++;
                Console.WriteLine((countA % 2 == 0) ? "ACEITA" : "REJEITA");
            }
            else if (opcao == "2")
            {
                if (cadeia.Length == 0) { Console.WriteLine("REJEITA"); return; }
                if (cadeia[0] != 'a') { Console.WriteLine("REJEITA"); return; }
                for (int i = 1; i < cadeia.Length; i++)
                {
                    if (cadeia[i] != 'b') { Console.WriteLine("REJEITA"); return; }
                }
                Console.WriteLine("ACEITA");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}