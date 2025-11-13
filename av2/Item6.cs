namespace ToolkitSigma
{
  class Item6
  {
    public static void ClassificadorPI()
    {
      Console.WriteLine("\nAV2: 6 - Classificar problema × instância por JSON");

      List<JsonTemplate> items;
      try
      {
        items = LeitorDeJson.ObterJsonEmbutido("problema_x_instancia.json");
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return;
      }

      int totalAcertos = 0;
      int totalErros = 0;

      foreach (JsonTemplate item in items)
      {
        Console.WriteLine($"\nFrase: {item.Texto}");

        char respostaUsuario = ' ';
        bool entradaValida = false;

        while (!entradaValida)
        {
          Console.Write("Classifique (P / I): ");
          string? entrada = Console.ReadLine()?.Trim().ToUpper();

          if (entrada == "P" || entrada == "I")
          {
            respostaUsuario = entrada[0];
            entradaValida = true;
          }
          else
          {
            Console.WriteLine("Entrada inválida. Digite apenas 'P' ou 'I'.");
          }
        }

        if (respostaUsuario == item.Correto)
        {
          Console.WriteLine("Correto.");
          totalAcertos++;
        }
        else
        {
          Console.WriteLine($"Incorreto. Resposta esperada: {item.Correto}");
          totalErros++;
        }
      }

      Console.WriteLine();
      Console.WriteLine($"Resumo: {totalAcertos} acertos e {totalErros} erros de {items.Count} itens.");
      Console.WriteLine();
    }
  }
}