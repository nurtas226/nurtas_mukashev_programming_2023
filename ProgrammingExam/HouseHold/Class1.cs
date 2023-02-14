using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHold
{
    internal class Class1
    {
        public int Water_Amount;
        public int Coffee_Amount;
        public int Grounds_Amount;
        public string brand;
        public const int Water_Limit = 500;
        public const int Coffee_Limit = 150;
        public const int Grounds_Limit = 50;
        public int Grounds_Level;

        public Class1(string Brand)
        {
            this.brand = Brand;

            if (string.IsNullOrEmpty(Brand))
            {
                throw new ArgumentException("Brand cannot be empty or null.");
            }
        }

        public void AddWater(int amount_water)
        {
            if (amount_water <= 0)
            {
                throw new ArgumentException("Amount accepts only positive amount of water");
            }

            if (Water_Amount + amount_water > Water_Limit)
            {
                throw new ArgumentException("You cannot add more water than the limit of the machine water container.");
            }

            Water_Amount += amount_water;
        }
        public void AddCoffee(int amount_coffee)
        {
            if (amount_coffee <= 0)
            {
                throw new ArgumentException("Coffee amount accepts only positive amount of coffee");
            }
            if (Coffee_Amount + amount_coffee > Coffee_Limit)
            {
                throw new ArgumentException("You cannot add more coffee than the limit of the machine coffee container.");
            }

            Coffee_Amount += amount_coffee;
        }

        public void MakeEspresso()
        {
            const int waterAmount = 20;
            const int coffeeAmount = 10;
            const int groundsAmount = 5;

            if (Water_Amount < waterAmount || Coffee_Amount < coffeeAmount)
            {
                throw new InvalidOperationException("Not enough coffee or water");
            }

            if (Grounds_Amount + groundsAmount > Grounds_Limit)
            {
                throw new InvalidOperationException("No more espresso can be made, limit of the grounds is reached!!!");
            }

            this.Water_Amount -= waterAmount;
            this.Coffee_Amount -= coffeeAmount;
            this.Grounds_Level += groundsAmount;
        }

        public void EmptyGrounds()
        {
            this.Grounds_Level = 0;
        }

    }
}
