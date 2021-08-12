using Converter;
using Logic;
using Logic.Logger;
using System;

namespace ConverterItVitaeOpdracht
{
    class Program
    {
        private static ConsoleKey optionMainReadKey;
        private static ConsoleKey optionAfterReadKey;
        private static double valueInput;
        private static double valueResult;

        private static IConverterService converter;
        private static ILogger logger;

        static void Main(string[] args)
        {
            start();
        }

        static void start()
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("use letter and it will crash.");
                Console.WriteLine("by using this application you agree not to use letters.");
                Console.WriteLine("press any key to agree");
                Console.WriteLine("---------------------------------------------------------");

                Console.ReadLine();
                logger = new IOLogger();
                converter = new ConverterService(logger);

                Console.WriteLine("Hello World!");
                MainConverterDialogWindow();
            }
            catch (Exception e)
            {
                start();
            }
        }

        static void MainConverterDialogWindow()
        {
            SelectConvertionOptionWindow();
            SelectValueMenu();
        }

        static void SelectValueMenu()
        {
            Clear();
            Console.WriteLine();
            Console.WriteLine($"Please enter what value you like to convert to...");
            valueInput = double.Parse(Console.ReadLine());
            ConverterValueResultMenu();
            AfterSelectConvertionOptionWindow();
      
        }

        static void ConverterValueResultMenu()
        {
            Clear();
            Console.WriteLine();
            valueResult = GetConversion(valueInput);

            Console.WriteLine($"{valueInput} => {valueResult}");
            Console.ReadLine();
        }

        static void Clear()
        {
            logger.Log("");
            Console.Clear();
        }

        static void AfterSelectConvertionOptionWindow()
        {
            Clear();
            Console.WriteLine();
            Console.WriteLine("What would you like to do now?");
            Console.WriteLine("[1] Opnieuw berekenen");
            Console.WriteLine("[2] Terug");
            Console.WriteLine("[3] Afsluiten");

            optionAfterReadKey = Console.ReadKey().Key;
            logger.Log("AfterSelectConvertionOptionWindow", optionAfterReadKey);

            if (optionAfterReadKey == ConsoleKey.D1)
                SelectValueMenu();
            if (optionAfterReadKey == ConsoleKey.D2)
                MainConverterDialogWindow();
            if (optionAfterReadKey == ConsoleKey.D3)
                CloseApplication();
        }

        static void SelectConvertionOptionWindow()
        {
            Clear();
            Console.WriteLine();

            Console.WriteLine(
                "Select convertion option: \n" +
                "[1] Meter naar centimeter \n" +
                "[2] Centimeter naar meter \n" +
                "[3] Centimeter naar millimeter \n" +
                "[4] Millimeter naar centimeter \n" +
                "[5] Meter naar inch \n" +
                "[6] Inch naar meter \n" +
                "[7] Afsluiten");

            optionMainReadKey = Console.ReadKey().Key;
            if (optionMainReadKey == ConsoleKey.D7)
                CloseApplication();
        }

        static double GetConversion(double input)
        {
            if (optionMainReadKey == ConsoleKey.D1)
            {
                return converter.MeterToCentimeter(input);
            }
            if (optionMainReadKey == ConsoleKey.D2)
            {
                return converter.CentimeterToMeter(input);
            }
            if (optionMainReadKey == ConsoleKey.D3)
            {
                return converter.CentimeterToMilimeter(input);
            }
            if (optionMainReadKey == ConsoleKey.D4)
            {
                return converter.MilimeterToCentimeter(input);
            }
            if (optionMainReadKey == ConsoleKey.D5)
            {
                return converter.MeterToInch(input);
            }
            if (optionMainReadKey == ConsoleKey.D6)
            {
                return converter.InchToMeter(input);
            }
            if (optionMainReadKey == ConsoleKey.D7)
            {
                CloseApplication();
                return -1;
            }
            return -1;
        }

        static void CloseApplication()
        {
            logger.Log("CloseApplication");
            Console.WriteLine("Application closed...");
        }
    }
}