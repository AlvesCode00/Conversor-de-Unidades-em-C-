
class Convencao
{
    public static void Menu()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU DE CONVERSOES =====");
            Console.WriteLine("\n--- COMPRIMENTO ---");
            Console.WriteLine("1 - Metros para centimetros");
            Console.WriteLine("2 - Centimetros para metros");
            Console.WriteLine("3 - Quilometros para metros");
            Console.WriteLine("4 - Metros para quilometros");
            Console.WriteLine("5 - Quilometros para milhas");
            Console.WriteLine("6 - Milhas para quilometros");
            Console.WriteLine("7 - Polegadas para centimetros");
            Console.WriteLine("8 - Centimetros para polegadas");

            Console.WriteLine("\n--- TEMPERATURA ---");
            Console.WriteLine("9 - Celsius para Fahrenheit");
            Console.WriteLine("10 - Fahrenheit para Celsius");

            Console.WriteLine("\n--- PESO ---");
            Console.WriteLine("11 - Quilogramas para gramas");
            Console.WriteLine("12 - Gramas para quilogramas");
            Console.WriteLine("13 - Quilogramas para libras");
            Console.WriteLine("14 - Libras para quilogramas");
            Console.WriteLine("15 - Toneladas para quilogramas");

            Console.WriteLine("\n--- VOLUME ---");
            Console.WriteLine("16 - Litros para mililitros");
            Console.WriteLine("17 - Mililitros para litros");

            Console.WriteLine("\n--- TEMPO ---");
            Console.WriteLine("18 - Minutos para segundos");
            Console.WriteLine("19 - Horas para minutos");
            Console.WriteLine("\n0 - Sair");

            Console.Write("Escolha uma opcao: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("\nOpcao invalida! Digite um numero.");
                continue;
            }

            switch (opcao)
            {
                case 1: ConvencaoMPorCm(); break;
                case 2: ConvencaoCmPorM(); break;
                case 3: ConvencaoKmPorM(); break;
                case 4: ConvencaoMPorKm(); break;
                case 5: ConvencaoKmPorMilhas(); break;
                case 6: ConvencaoMilhasPorKm(); break;
                case 7: ConvencaoPolegadasPorCm(); break;
                case 8: ConvencaoCmPorPolegadas(); break;
                case 9: ConvencaoCelsiusPorFahrenheit(); break;
                case 10: ConvencaoFahrenheitPorCelsius(); break;
                case 11: ConvencaoKgPorG(); break;
                case 12: ConvencaoGPorKg(); break;
                case 13: ConvencaoKgPorLibras(); break;
                case 14: ConvencaoLibrasPorKg(); break;
                case 15: ConvencaoToneladasPorKg(); break;
                case 16: ConvencaoLitrosPorMl(); break;
                case 17: ConvencaoMlPorLitros(); break;
                case 18: ConvencaoMinPorSeg(); break;
                case 19: ConvencaoHorasPorMin(); break;
                case 0: Console.WriteLine("\nEncerrando o programa..."); break;
                default: Console.WriteLine("\nOpcao invalida! Escolha uma opcao do menu."); break;
            }

        } while (opcao != 0);
    }

    static double LerValor(string mensagem)
    {
        double valor;

        while (true)
        {
            Console.Write(mensagem);

            if (double.TryParse(Console.ReadLine(), out valor))
                return valor;

            Console.WriteLine("Valor invalido! Digite um numero valido.\n");
        }
    }

    static void ConvencaoMPorCm()
    {
        Console.WriteLine("\nConverta metros em centimetros. Cada metro equivale a 100 centimetros.\n");
        double metros = LerValor("Digite o valor em metros: ");
        double centimetros = metros * 100;
        Console.WriteLine($"Resultado: {centimetros} cm");

         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
    }

    static void ConvencaoCmPorM()
    {
        Console.WriteLine("\nConverta centimetros em metros. A cada 100 centimetros, temos 1 metro.\n");
        double cm = LerValor("Digite o valor em centimetros: ");
        double metros = cm / 100;
        Console.WriteLine($"Resultado: {metros} m");

         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoKmPorM()
    {
        Console.WriteLine("\nConverta quilometros em metros. Cada quilometro equivale a 1.000 metros.\n");
        double km = LerValor("Digite o valor em quilometros: ");
        double metros = km * 1000;
        Console.WriteLine($"Resultado: {metros} m");

         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoMPorKm()
    {
        Console.WriteLine("\nConverta metros em quilometros. A cada 1.000 metros, temos 1 quilometro.\n");
        double metros = LerValor("Digite o valor em metros: ");
        double km = metros / 1000;
        Console.WriteLine($"Resultado: {km} km");

         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoKmPorMilhas()
    {
        Console.WriteLine("\nConverta quilometros em milhas. Cada quilometro equivale a aproximadamente 0,621371 milha.\n");
        double km = LerValor("Digite o valor em quilometros: ");
        double milhas = km / 1.609344;
        Console.WriteLine($"Resultado: {milhas} milhas");
    
         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoMilhasPorKm()
    {
        Console.WriteLine("\nConverta milhas em quilometros. Cada milha equivale a aproximadamente 1,609344 quilometro.\n");
        double milhas = LerValor("Digite o valor em milhas: ");
        double km = milhas * 1.609344;
        Console.WriteLine($"Resultado: {km} km");
    
         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoPolegadasPorCm()
    {
        Console.WriteLine("\nConverta polegadas em centimetros. Cada polegada equivale a 2,54 centimetros.\n");
        double polegadas = LerValor("Digite o valor em polegadas: ");
        double cm = polegadas * 2.54;
        Console.WriteLine($"Resultado: {cm} cm");

         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoCmPorPolegadas()
    {
        Console.WriteLine("\nConverta centimetros em polegadas. Cada polegada corresponde a 2,54 centimetros.\n");
        double cm = LerValor("Digite o valor em centimetros: ");
        double polegadas = cm / 2.54;
        Console.WriteLine($"Resultado: {polegadas} polegadas");
    
         Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
            
    }

    static void ConvencaoCelsiusPorFahrenheit()
    {
        Console.WriteLine("\nConverta Celsius para Fahrenheit.\n");
        double celsius = LerValor("Digite o valor em Celsius: ");
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Resultado: {fahrenheit} Fahrenheit");
        
            Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();


    }

    static void ConvencaoFahrenheitPorCelsius()
    {
        Console.WriteLine("\nConverta Fahrenheit para Celsius.\n");
        double fahrenheit = LerValor("Digite o valor em Fahrenheit: ");
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Resultado: {celsius} Celsius");

            Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoKgPorG()
    {
        Console.WriteLine("\nConverta quilogramas em gramas. Cada quilograma equivale a 1.000 gramas.\n");
        double kg = LerValor("Digite o valor em quilogramas: ");
        double gramas = kg * 1000;
        Console.WriteLine($"Resultado: {gramas} gramas");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoGPorKg()
    {
        Console.WriteLine("\nConverta gramas em quilogramas. A cada 1.000 gramas, temos 1 quilograma.\n");
        double gramas = LerValor("Digite o valor em gramas: ");
        double kg = gramas / 1000;
        Console.WriteLine($"Resultado: {kg} kg");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoKgPorLibras()
    {
        Console.WriteLine("\nConverta quilogramas em libras. Cada quilograma equivale a aproximadamente 2,20462 libras.\n");
        double kg = LerValor("Digite o valor em quilogramas: ");
        double libras = kg * 2.20462;
        Console.WriteLine($"Resultado: {libras} libras");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoLibrasPorKg()
    {
        Console.WriteLine("\nConverta libras em quilogramas.\n");
        double libras = LerValor("Digite o valor em libras: ");
        double kg = libras / 2.20462;
        Console.WriteLine($"Resultado: {kg} kg");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoToneladasPorKg()
    {
        Console.WriteLine("\nConverta toneladas em quilogramas. Cada tonelada equivale a 1.000 quilogramas.\n");
        double toneladas = LerValor("Digite o valor em toneladas: ");
        double kg = toneladas * 1000;
        Console.WriteLine($"Resultado: {kg} kg");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoLitrosPorMl()
    {
        Console.WriteLine("\nConverta litros em mililitros. Cada litro equivale a 1.000 mililitros.\n");
        double litros = LerValor("Digite o valor em litros: ");
        double ml = litros * 1000;
        Console.WriteLine($"Resultado: {ml} ml");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
            
    }

    static void ConvencaoMlPorLitros()
    {
        Console.WriteLine("\nConverta mililitros em litros.\n");
        double ml = LerValor("Digite o valor em mililitros: ");
        double litros = ml / 1000;
        Console.WriteLine($"Resultado: {litros} litros");
                
                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
    }

    static void ConvencaoMinPorSeg()
    {
        Console.WriteLine("\nConverta minutos em segundos. Cada minuto equivale a 60 segundos.\n");
        double minutos = LerValor("Digite o valor em minutos: ");
        double segundos = minutos * 60;
        Console.WriteLine($"Resultado: {segundos} segundos");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();

    }

    static void ConvencaoHorasPorMin()
    {
        Console.WriteLine("\nConverta horas em minutos. Cada hora equivale a 60 minutos.\n");
        double horas = LerValor("Digite o valor em horas: ");
        double minutos = horas * 60;
        Console.WriteLine($"Resultado: {minutos} minutos");

                 Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
            
    }
}
