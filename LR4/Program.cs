using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartProgram();
            }
            catch (Exception)
            {
                Console.WriteLine("Не вдалося завершити програму, перевiрте правильнiсть введення!");
            }
        }

        private static void StartProgram()
        {
            Console.Write("Введiть назву мiста: ");
            string cityName = Console.ReadLine();

            Console.Write("Введiть назву краiни: ");
            string countryName = Console.ReadLine();

            Console.Write("Введiть назву регiону: ");
            string regionName = Console.ReadLine();

            Console.Write("Введiть кiлькiсть населення: ");
            int cityPopulation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть рiчний дохiд: ");
            int cityYearProfit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть площу, кв. км: ");
            int cityPlace = Convert.ToInt32(Console.ReadLine());

            Console.Write("Чи є у мiстi порт? (y-так, n-нi): ");
            bool cityPort = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();

            Console.Write("Чи є у мiстi аеропорт? (y-так, n-нi): ");
            bool cityAirport = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();

            City city = new City(cityName, countryName, regionName, cityPopulation, cityYearProfit, cityPlace, cityPort, cityAirport);

            ShowData(city);
        }

        private static void ShowData(City city)
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Данi про об'єкт");

            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine($"Назва: {city.Name}");
            Console.WriteLine($"Країна: {city.Country}");
            Console.WriteLine($"Область: {city.Region}");
            Console.WriteLine($"Кiлькість населення: {city.Population}");
            Console.WriteLine($"Рiчний дохід: {city.YearProfit}");
            Console.WriteLine($"Площадь: {city.Place} кв. км");

            string isPort = city.Port ? "Да" : "Нi";
            Console.WriteLine($"Чи є порт: {isPort}");

            string isAirport = city.Airport ? "Да" : "Нi";
            Console.WriteLine($"Чи є аеропорт: {isAirport}");

            Console.ForegroundColor = ConsoleColor.Green;
            int inhabitantYearProfit = city.InhabitantProfit();

            Console.WriteLine($"Рiчний дохiд мешканця: {inhabitantYearProfit}");
            Console.ResetColor();

            Console.ReadKey();
        }
    }

    class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public int YearProfit { get; set; }
        public int Place { get; set; }
        public bool Airport { get; set; }
        public bool Port { get; set; }

        public City(
            string name,
            string country,
            string region,
            int population,
            int year_profit,
            int place,
            bool port,
            bool airport
            )
        {
            this.Name = name;
            this.Country = country;
            this.Region = region;
            this.Population = population;
            this.YearProfit = year_profit;
            this.Place = place;
            this.Port = port;
            this.Airport = airport;
        }

        public int InhabitantProfit()
        {
            return this.YearProfit / this.Population;
        }
    }
}
