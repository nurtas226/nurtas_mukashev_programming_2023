using HouseHold;

namespace CoffeMachine
{ 
    class Run_the_program
    {
        static void Main(string[] args)
        {
            var Coffee_Machine = new Class1("CoffeeMachine");

            Coffee_Machine.AddCoffee(50);
            Coffee_Machine.AddWater(100);

            Console.WriteLine("Water Level: " + Coffee_Machine.Water_Amount);
            Console.WriteLine("Coffee Level: " + Coffee_Machine.Coffee_Amount);
            Console.WriteLine("Grounds Level: " + Coffee_Machine.Grounds_Level);

            Coffee_Machine.MakeEspresso();

            Console.WriteLine("Water Level: " + Coffee_Machine.Water_Amount);
            Console.WriteLine("Coffee Level: " + Coffee_Machine.Coffee_Amount);
            Console.WriteLine("Grounds Level: " + Coffee_Machine.Grounds_Level);



            Coffee_Machine.EmptyGrounds();
            Coffee_Machine.MakeEspresso();

            Console.WriteLine("Water Level: " + Coffee_Machine.Water_Amount);
            Console.WriteLine("Coffee Level: " + Coffee_Machine.Coffee_Amount);
            Console.WriteLine("Grounds Level: " + Coffee_Machine.Grounds_Level);



        }
    }

}
