namespace variableopdracht2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Fiets
        string merk = "Gazelle";
        int versnellingen = 3;
        double framemaat = 2;
        bool heeftBel = true;

        Console.WriteLine(merk);
        Console.WriteLine(versnellingen);
        Console.WriteLine(framemaat);
        Console.WriteLine(heeftBel);

        // Videogame chracter
        // - maak 4 variabelen aan:
        // - een int met een nummer
        // - een string met een videogame character naam
        // - een bool die op false staat
        // - een float met een nummer (vergeet de f niet achter het nummer)
        // - gebruik console writeline om:
        // - de variabelen op het scherm te zetten
        string DnDcharacter = "Athoz";
        int HP = 31;
        bool usesMagic = false;
        float damageDealt = 26f;

        Console.WriteLine(DnDcharacter);
        Console.WriteLine(HP);
        Console.WriteLine(usesMagic);
        Console.WriteLine(damageDealt);

        //Sure! Here's an exercise where you can practice declaring and assigning variables related to a real-world scenario.
        // //Exercise: Car Rental System
        // Imagine you are developing a simple car rental system. You need to keep track of various properties of a car rental order. For this, you need to declare variables and assign appropriate values to them.
        // Here are the variables you need to create:
        // Car Model: The model of the car being rented.
        // Rental Duration: The number of days the car is rented for.
        // Rental Price per Day: The cost of renting the car per day.
        // Customer Name: The name of the customer renting the car.
        // Total Rental Cost: The total cost for the rental (calculated as Rental Duration * Rental Price per Day).
        // Is Insurance Included: Whether the rental includes insurance or not (true or false).
        // Rental Start Date: The start date of the rental.
        // Car Year: The year the car was manufactured.
        // Make sure to declare each variable with an appropriate type (string, int, double, DateTime, bool, etc.), and assign values to them as though you're renting out a car for a customer.
        // Once you've declared and assigned all variables, think about how these would interact in a real-world application (though you won't be coding the logic here—just focus on the declaration and assignment).

        string carModel = "Ford Mustang zwart 1967 1:18";
        int rentalDurationDays = 5;
        int rentalPricePerDayinEuros = 101;
        string customerName = "Geraldine Bob";
        int totalRentalCostinEuros = 505;
        bool isInsuranceIncluded = true;
        float rentalStartDate = 30f;
        int carYear = 1967;

        Console.WriteLine(carModel);
        Console.WriteLine(rentalDurationDays);
        Console.WriteLine(rentalPricePerDayinEuros);
        Console.WriteLine(customerName);
        Console.WriteLine(totalRentalCostinEuros);
        Console.WriteLine(isInsuranceIncluded);
        Console.WriteLine(rentalStartDate);
        Console.WriteLine(carYear);

    }
}
