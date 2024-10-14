namespace loadingassessment4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Display options for car types
            Console.WriteLine("1. Sports car");
            Console.WriteLine("2. SUV car");
            Console.WriteLine("3. None of the above");
            Console.Write("Choose the option: ");
            int option = int.Parse(Console.ReadLine());

            // Variables for car details
            string make, model;
            int yearMade, currentYear;
            double basicPrice;

            // Get car details from the user
            Console.Write("Enter the make: ");
            make = Console.ReadLine();

            Console.Write("Enter the model: ");
            model = Console.ReadLine();

            Console.Write("Enter the year the car was made: ");
            yearMade = int.Parse(Console.ReadLine());

            Console.Write("Enter the basic price: ");
            basicPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the current year: ");
            currentYear = int.Parse(Console.ReadLine());

            // Calculate and display the car cost based on the selected option
            switch (option)
            {
                case 1: // Sports car
                    double sportsCarCost = CalculateSportsCarCost(basicPrice, yearMade, currentYear);
                    Console.WriteLine($"Sports car cost is {sportsCarCost}");
                    break;

                case 2: // SUV car
                    double suvCarCost = CalculateSuvCarCost(basicPrice, yearMade, currentYear);
                    Console.WriteLine($"SUV car cost is {suvCarCost}");
                    break;

                case 3: // None of the above
                    Console.WriteLine($"The cost is {basicPrice}");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        // Method to calculate the cost of a sports car
        public static double CalculateSportsCarCost(double basicPrice, int yearMade, int currentYear)
        {
            int age = currentYear - yearMade;
            double appreciationFactor = Math.Pow(1.1, age); // 10% appreciation per year
            return basicPrice * 100000 * appreciationFactor; // Basic price multiplied by 100,000
        }

        // Method to calculate the cost of an SUV car
        public static double CalculateSuvCarCost(double basicPrice, int yearMade, int currentYear)
        {
            int age = currentYear - yearMade;
            double depreciationFactor = Math.Pow(0.9, age); // 10% depreciation per year
            return basicPrice * 100000 * depreciationFactor; // Basic price multiplied by 100,000
        }
    }

}
