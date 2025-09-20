namespace ToolkitSigma
{

    class Item3
    {
        public static void TerminaComB()
        {
            Console.WriteLine("3 - Verficar se termina com 'b'");
            Console.Write("Digite uma cadeia (apenas a/b): ");
            string? cadeia = Console.ReadLine() ?? "";
            foreach (char c in cadeia)
            {
                if (c != 'a' && c != 'b')
                {
                    Console.WriteLine("Cadeia inválida: contém símbolos fora de Σ.");
                    return;
                }
            }
            if (cadeia.Length == 0)
            {
                Console.WriteLine("Entrada é cadeia vazia. Resposta: NAO");
                return;
            }
            Console.WriteLine(cadeia[^1] == 'b' ? "SIM" : "NAO");
        }

    }
}