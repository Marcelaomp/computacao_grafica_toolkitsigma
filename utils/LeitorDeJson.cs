using System.Text.Json;

namespace ToolkitSigma
{
    class LeitorDeJson
    {
        public static List<JsonTemplate> ObterJsonEmbutido(string nomeJson)
        {          
            string path = Path.Combine(AppContext.BaseDirectory, "data", nomeJson);
            if (!File.Exists(path))
            {
                throw new Exception("Arquivo de dados não encontrado: " + path);
            }
            string json = File.ReadAllText(path);
            List<JsonTemplate>? listaItens = JsonSerializer.Deserialize<List<JsonTemplate>>(json);
            if (listaItens == null)
            {
                throw new Exception("Erro ao desserializar JSON.");
            }
            return listaItens;
        }

    }
}