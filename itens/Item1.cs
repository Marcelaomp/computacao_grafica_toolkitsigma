namespace ToolkitSigma
{

    class Item1
    {
        public static void Verificador()
        {
            Console.WriteLine("1 - Verificar de alfabeto e cadeia (Σ = {a,b})");
            Console.Write("Digite um símbolo (caractere): ");
            string? simbolo = Console.ReadLine();
            bool simboloValido = !string.IsNullOrEmpty(simbolo) && simbolo.Length == 1 && (simbolo == "a" || simbolo == "b");
            Console.WriteLine(simboloValido ? "Símbolo VÁLIDO no alfabeto Σ." : "Símbolo INVÁLIDO.");

            Console.Write("Digite uma cadeia (apenas 'a' e 'b' permitidos): ");
            string? cadeia = Console.ReadLine() ?? "";
            bool cadeiaValida = true;
            foreach (char c in cadeia)
            {
                if (c != 'a' && c != 'b')
                {
                    cadeiaValida = false;
                    break;
                }
            }
            Console.WriteLine(cadeiaValida ? "Cadeia VÁLIDA em Σ*." : "Cadeia INVÁLIDA (contém símbolos fora de Σ).");
        }
    }
}