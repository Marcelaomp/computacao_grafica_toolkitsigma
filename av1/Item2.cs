using System.Text.Json;

namespace ToolkitSigma
{

    class Item2
    {
        public static void ClassificadorJson()
        {
            Console.WriteLine("AV1: 2 - Classificar T/I/N por JSON");

            List<JsonTemplate> items;
            try
            {
                items = LeitorDeJson.ObterJsonEmbutido("classificacao_T_I_N.json");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            int total = 0;
            int acertos = 0;
            foreach (JsonTemplate item in items)
            {
                total++;
                Console.WriteLine();
                Console.WriteLine($"Item {total}: {item.Texto}");
                Console.Write("Classifique como (T)ratável / (I)ntratável / (N)ão computável: ");
                string? resposta = (Console.ReadLine() ?? "").Trim().ToUpper();
                char resp = resposta.Length > 0 ? resposta[0] : '?';
                if (resp == item.Correto)
                {
                    acertos++;
                    Console.WriteLine("Correto.");
                }
                else
                {
                    Console.WriteLine($"Incorreto. Resposta esperada: {item.Correto}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Resumo: {acertos} acertos de {total} itens.");
            Console.WriteLine();
        }
    }
}

