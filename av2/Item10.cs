namespace ToolkitSigma
{

    class Item10
    {
        public static void SimuladorAFD()
        {
            Console.WriteLine("\nAV2: 10 - Simular AFD de casos fixos");

            // AFD simples que aceita a linguagem L = { w | w termina com "aa" }
            // Estados = {q0, q1, q2}
            // Estado Inicial = q0
            // Estados Finais = {q2}
            // Transições:
            // (q0, a) -> q1
            // (q0, b) -> q0
            // (q1, a) -> q2
            // (q1, b) -> q0
            // (q2, a) -> q2
            // (q2, b) -> q0

            Console.WriteLine("AFD Fixo: L = { w em {a,b}* | w termina com 'aa' }");

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

            string estadoAtual = "q0";
            Console.WriteLine($"Iniciando em: {estadoAtual}");

            foreach (char simbolo in cadeia)
            {
                string proximoEstado = estadoAtual;

                switch (estadoAtual)
                {
                    case "q0":
                        if (simbolo == 'a') proximoEstado = "q1";
                        else proximoEstado = "q0";
                        break;

                    case "q1":
                        if (simbolo == 'a') proximoEstado = "q2";
                        else proximoEstado = "q0";
                        break;

                    case "q2":
                        if (simbolo == 'a') proximoEstado = "q2";
                        else proximoEstado = "q0";
                        break;
                }

                Console.WriteLine($"Simbolo lido: '{simbolo}'. Estado atual: {estadoAtual} -> Próximo estado: {proximoEstado}");
                estadoAtual = proximoEstado;
            }

            Console.WriteLine($"\nProcessamento concluído. Estado final: {estadoAtual}");

            if (estadoAtual == "q2")
            {
                Console.WriteLine("\nACEITA");
            }
            else
            {
                Console.WriteLine("\nREJEITA");
            }
            Console.WriteLine();
        }
    }
}