namespace ToolkitSigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Toolkit Sigma ===");
            Console.WriteLine();
            bool mostrarMenu = true;
            while (mostrarMenu)
            {
                CriarMenu();
                Console.WriteLine();
                string? opcao = SolicitarOpcao();
                if (opcao == "0") break;
                Console.WriteLine();                
                DirecionarUsuario(opcao);
            }
            Console.WriteLine("Processo Finalizado.");
        }

        static void CriarMenu()
        {
            Console.WriteLine("Menu:");

            Console.WriteLine("===================== AV1 =====================");
            Console.WriteLine("1 - Verificar de alfabeto e cadeia (Σ = {a,b})");
            Console.WriteLine("2 - Classificar T/I/N por JSON");
            Console.WriteLine("3 - Verficar se termina com 'b'");
            Console.WriteLine("4 - Avaliar proposições básicas");
            Console.WriteLine("5 - Reconhecer Σ={a,b}: L_par_a e a b*");

            Console.WriteLine("\n===================== AV2 =====================");
            Console.WriteLine("6 - Classificar problema × instância por JSON");
            Console.WriteLine("7 - Decidir Σ={a,b}: L_fim_b e L_mult3_b");
            Console.WriteLine("8 - Demonstrar reconhecedor que pode não terminar");
            Console.WriteLine("9 - Utilizar detector ingênuo de loop + reflexão");
            Console.WriteLine("10 - Simular AFD de casos fixos");

            Console.WriteLine("0 - Sair");
        }

        static string? SolicitarOpcao()
        {
            Console.Write("Escolha uma opção: ");
            return Console.ReadLine();
        }

        static void DirecionarUsuario(string? inputUsuario)
        {
            switch (inputUsuario)
            {
                case "1": Item1.Verificador(); break;
                case "2": Item2.ClassificadorJson(); break;
                case "3": Item3.TerminaComB(); break;
                case "4": Item4.AvaliadorProposicional(); break;
                case "5": Item5.Reconhecedor(); break;
                case "6": Item6.ClassificadorPI(); break;
                case "7": Item7.Decisor(); break;
                case "8": Item8.ReconhecedorNaoTermina(); break;
                case "9": Item9.DetectorLoopIngenuo(); break;
                case "10": Item10.SimuladorAFD(); break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }         
    }

    // AV2
}