// ============================================================
//   Lista de Exercícios IV — Algoritmos e Programação
//   Centro Universitário UNA
//   Professor: Daniel Henrique Matos de Paiva
//   Linguagem: C#
// ============================================================

using System;

class ListaIV
{
    // ============================================================
    // PONTO DE ENTRADA — MENU PRINCIPAL COM SWITCH CASE
    // ============================================================
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            ExibirMenu();
            Console.Write("Escolha um exercício (0 para sair): ");
            string opcao = Console.ReadLine();

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Exercicio01_ValidacaoNota();
                    break;
                case "2":
                    Exercicio02_ValidacaoSenha();
                    break;
                case "3":
                    Exercicio03_ValidacaoCadastro();
                    break;
                case "4":
                    Exercicio04_CrescimentoPopulacionalFixo();
                    break;
                case "5":
                    Exercicio05_CrescimentoPopulacionalDinamico();
                    break;
                case "6":
                    Exercicio06_ImprimirNumeros();
                    break;
                case "7":
                    Exercicio07_MaiorNumero();
                    break;
                case "8":
                    Exercicio08_SomaMedia();
                    break;
                case "9":
                    Exercicio09_NumerosImpares();
                    break;
                case "10":
                    Exercicio10_Intervalo();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("Encerrando o sistema. Até logo!");
                    break;
                default:
                    Console.WriteLine("❌ Opção inválida! Digite um número de 1 a 10 ou 0 para sair.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    // ============================================================
    // MENU PRINCIPAL
    // ============================================================
    static void ExibirMenu()
    {
        Console.WriteLine("╔══════════════════════════════════════════════════════╗");
        Console.WriteLine("║        LISTA IV — ALGORITMOS E PROGRAMAÇÃO          ║");
        Console.WriteLine("║         Centro Universitário UNA — Prof. Paiva      ║");
        Console.WriteLine("╠══════════════════════════════════════════════════════╣");
        Console.WriteLine("║  [01] Validação de Nota (0 a 10)                    ║");
        Console.WriteLine("║  [02] Validação de Usuário e Senha                  ║");
        Console.WriteLine("║  [03] Validação de Cadastro Completo                ║");
        Console.WriteLine("║  [04] Crescimento Populacional (fixo)               ║");
        Console.WriteLine("║  [05] Crescimento Populacional (dinâmico)           ║");
        Console.WriteLine("║  [06] Imprimir Números de 1 a 20                    ║");
        Console.WriteLine("║  [07] Maior entre 5 Números                         ║");
        Console.WriteLine("║  [08] Soma e Média de 5 Números                     ║");
        Console.WriteLine("║  [09] Números Ímpares entre 1 e 50                  ║");
        Console.WriteLine("║  [10] Números em um Intervalo                       ║");
        Console.WriteLine("║  [00] Sair                                          ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════╝");
    }

    // ============================================================
    // EXERCÍCIO 01 — Validação de Nota
    // ============================================================
    static void Exercicio01_ValidacaoNota()
    {
        Console.WriteLine("=== Exercício 01 — Validação de Nota ===\n");

        double nota = -1;

        do
        {
            Console.Write("Digite uma nota entre 0 e 10: ");
            string entrada = Console.ReadLine();
            bool converteu = double.TryParse(entrada, out nota);

            if (!converteu || nota < 0 || nota > 10)
            {
                Console.WriteLine("❌ Valor inválido! Digite um número entre 0 e 10.\n");
                nota = -1;
            }

        } while (nota < 0 || nota > 10);

        Console.WriteLine($"\n✅ Nota válida registrada: {nota}");
    }

    // ============================================================
    // EXERCÍCIO 02 — Validação de Usuário e Senha
    // ============================================================
    static void Exercicio02_ValidacaoSenha()
    {
        Console.WriteLine("=== Exercício 02 — Validação de Usuário e Senha ===\n");

        string usuario = "";
        string senha   = "";

        do
        {
            Console.Write("Nome de usuário: ");
            usuario = Console.ReadLine();

            Console.Write("Senha: ");
            senha = Console.ReadLine();

            if (senha == usuario)
            {
                Console.WriteLine("❌ Erro: a senha não pode ser igual ao nome de usuário. Tente novamente.\n");
            }

        } while (senha == usuario);

        Console.WriteLine($"\n✅ Cadastro aceito! Bem-vindo, {usuario}.");
    }

    // ============================================================
    // EXERCÍCIO 03 — Validação de Cadastro Completo
    // ============================================================
    static void Exercicio03_ValidacaoCadastro()
    {
        Console.WriteLine("=== Exercício 03 — Validação de Cadastro ===\n");

        // Nome
        string nome = "";
        do
        {
            Console.Write("Nome (mínimo 3 caracteres): ");
            nome = Console.ReadLine();
            if (nome.Length <= 3)
                Console.WriteLine("❌ Nome inválido! Deve ter mais de 3 caracteres.\n");
        } while (nome.Length <= 3);

        // Idade
        int idade = -1;
        do
        {
            Console.Write("Idade (0 a 150): ");
            bool ok = int.TryParse(Console.ReadLine(), out idade);
            if (!ok || idade < 0 || idade > 150)
            {
                Console.WriteLine("❌ Idade inválida! Deve estar entre 0 e 150.\n");
                idade = -1;
            }
        } while (idade < 0 || idade > 150);

        // Salário
        double salario = 0;
        do
        {
            Console.Write("Salário (maior que zero): ");
            bool ok = double.TryParse(Console.ReadLine(), out salario);
            if (!ok || salario <= 0)
            {
                Console.WriteLine("❌ Salário inválido! Deve ser maior que zero.\n");
                salario = 0;
            }
        } while (salario <= 0);

        // Sexo
        string sexo = "";
        do
        {
            Console.Write("Sexo (f/m): ");
            sexo = Console.ReadLine().ToLower().Trim();
            if (sexo != "f" && sexo != "m")
                Console.WriteLine("❌ Sexo inválido! Digite 'f' ou 'm'.\n");
        } while (sexo != "f" && sexo != "m");

        // Estado Civil
        string estadoCivil = "";
        do
        {
            Console.Write("Estado Civil (s=solteiro, c=casado, v=viúvo, d=divorciado): ");
            estadoCivil = Console.ReadLine().ToLower().Trim();
            if (estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d")
                Console.WriteLine("❌ Estado civil inválido! Use: s, c, v ou d.\n");
        } while (estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d");

        Console.WriteLine("\n✅ Cadastro realizado com sucesso!");
        Console.WriteLine($"   Nome: {nome} | Idade: {idade} | Salário: R$ {salario:F2} | Sexo: {sexo.ToUpper()} | Estado Civil: {estadoCivil.ToUpper()}");
    }

    // ============================================================
    // EXERCÍCIO 04 — Crescimento Populacional (valores fixos)
    // ============================================================
    static void Exercicio04_CrescimentoPopulacionalFixo()
    {
        Console.WriteLine("=== Exercício 04 — Crescimento Populacional (fixo) ===\n");

        double popA = 80000;
        double taxaA = 0.03;

        double popB = 200000;
        double taxaB = 0.015;

        int anos = 0;

        Console.WriteLine($"População A: {popA:N0} hab | Taxa: {taxaA * 100}% a.a.");
        Console.WriteLine($"População B: {popB:N0} hab | Taxa: {taxaB * 100}% a.a.\n");

        while (popA < popB)
        {
            popA *= (1 + taxaA);
            popB *= (1 + taxaB);
            anos++;
        }

        Console.WriteLine($"✅ Após {anos} anos, a população A ({popA:N0}) ultrapassa ou iguala a população B ({popB:N0}).");
    }

    // ============================================================
    // EXERCÍCIO 05 — Crescimento Populacional (dinâmico)
    // ============================================================
    static void Exercicio05_CrescimentoPopulacionalDinamico()
    {
        Console.WriteLine("=== Exercício 05 — Crescimento Populacional (dinâmico) ===\n");

        bool repetir = true;

        while (repetir)
        {
            double popA = LerDouble("População inicial do país A (habitantes): ", 1);
            double taxaA = LerDouble("Taxa de crescimento anual de A (em %): ", 0.01) / 100;

            double popB = LerDouble("População inicial do país B (habitantes): ", 1);
            double taxaB = LerDouble("Taxa de crescimento anual de B (em %): ", 0.01) / 100;

            if (taxaA <= taxaB)
            {
                Console.WriteLine("\n⚠️  A taxa de A deve ser maior que a de B para que A ultrapasse B. Tente novamente.\n");
                continue;
            }

            int anos = 0;
            while (popA < popB)
            {
                popA *= (1 + taxaA);
                popB *= (1 + taxaB);
                anos++;
            }

            Console.WriteLine($"\n✅ Após {anos} anos, A ({popA:N0}) supera B ({popB:N0}).");
            Console.Write("\nDeseja calcular novamente? (s/n): ");
            repetir = Console.ReadLine().ToLower().Trim() == "s";
            Console.WriteLine();
        }
    }

    // ============================================================
    // EXERCÍCIO 06 — Imprimir números de 1 a 20
    // ============================================================
    static void Exercicio06_ImprimirNumeros()
    {
        Console.WriteLine("=== Exercício 06 — Números de 1 a 20 ===\n");

        Console.WriteLine("--- Um abaixo do outro ---");
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n--- Um ao lado do outro ---");
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i + (i < 20 ? " | " : "\n"));
        }
    }

    // ============================================================
    // EXERCÍCIO 07 — Maior entre 5 números
    // ============================================================
    static void Exercicio07_MaiorNumero()
    {
        Console.WriteLine("=== Exercício 07 — Maior entre 5 Números ===\n");

        double maior = double.MinValue;

        for (int i = 1; i <= 5; i++)
        {
            double num = LerDouble($"Digite o {i}º número: ", double.MinValue);
            if (num > maior)
                maior = num;
        }

        Console.WriteLine($"\n✅ O maior número informado foi: {maior}");
    }

    // ============================================================
    // EXERCÍCIO 08 — Soma e Média de 5 números
    // ============================================================
    static void Exercicio08_SomaMedia()
    {
        Console.WriteLine("=== Exercício 08 — Soma e Média de 5 Números ===\n");

        double soma = 0;

        for (int i = 1; i <= 5; i++)
        {
            double num = LerDouble($"Digite o {i}º número: ", double.MinValue);
            soma += num;
        }

        double media = soma / 5;

        Console.WriteLine($"\n✅ Soma: {soma}");
        Console.WriteLine($"✅ Média: {media:F2}");
    }

    // ============================================================
    // EXERCÍCIO 09 — Números ímpares entre 1 e 50
    // ============================================================
    static void Exercicio09_NumerosImpares()
    {
        Console.WriteLine("=== Exercício 09 — Números Ímpares entre 1 e 50 ===\n");

        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0)
                Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    // ============================================================
    // EXERCÍCIO 10 — Números em um intervalo
    // ============================================================
    static void Exercicio10_Intervalo()
    {
        Console.WriteLine("=== Exercício 10 — Números em um Intervalo ===\n");

        int a = (int)LerDouble("Digite o primeiro número inteiro: ", double.MinValue);
        int b = (int)LerDouble("Digite o segundo número inteiro: ", double.MinValue);

        int inicio = Math.Min(a, b);
        int fim    = Math.Max(a, b);

        Console.WriteLine($"\nNúmeros entre {inicio} e {fim}:");
        for (int i = inicio; i <= fim; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    // ============================================================
    // UTILITÁRIO — Leitura de double com validação de mínimo
    // ============================================================
    static double LerDouble(string mensagem, double minimo)
    {
        double valor;
        bool valido;

        do
        {
            Console.Write(mensagem);
            valido = double.TryParse(Console.ReadLine(), out valor);

            if (!valido || valor < minimo)
            {
                Console.WriteLine($"❌ Entrada inválida! Tente novamente.\n");
                valido = false;
            }

        } while (!valido);

        return valor;
    }
}