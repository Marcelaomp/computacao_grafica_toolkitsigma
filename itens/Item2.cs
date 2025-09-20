using System.Text.Json;
using System.Text.Json.Serialization;

namespace ToolkitSigma
{

    class Item2
    {
        public static void ClassificadorJson()
        {
            Console.WriteLine("2 - Classificar T/I/N por JSON");
            string path = Path.Combine(AppContext.BaseDirectory, "data", "classificacao.json");
            if (!File.Exists(path))
            {
                Console.WriteLine("Arquivo de dados não encontrado: " + path);
                return;
            }
            string json = File.ReadAllText(path);
            List<Classificacao>? items = JsonSerializer.Deserialize<List<Classificacao>>(json);
            if (items == null)
            {
                Console.WriteLine("Erro ao desserializar JSON.");
                return;
            }

            int total = 0;
            int acertos = 0;
            foreach (Classificacao item in items)
            {
                total++;
                Console.WriteLine();
                Console.WriteLine($"Item {total}: {item.Texto}");
                Console.Write("Classifique como (T)ratável / (I)ntratável / (N)ão computável: ");
                string? resposta = (Console.ReadLine() ?? "").Trim().ToUpper();
                char resp = resposta.Length > 0 ? resposta[0] : '?';
                if (resp == item.Correcto)
                {
                    acertos++;
                    Console.WriteLine("Correto.");
                }
                else
                {
                    Console.WriteLine($"Incorreto. Resposta esperada: {item.Correcto}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Resumo: {acertos} acertos de {total} itens.");
        }
    }
}

class Classificacao
{
    [JsonPropertyName("texto")]
    public string Texto { get; set; } = string.Empty;
    [JsonPropertyName("correcto")]
    public char Correcto { get; set; } = '?';
}