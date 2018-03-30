using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BurgerThing
{
    public static class BurgerEnums
    {
        public const string WHITE_BUN_STRING = "White Bun";
        public const string ONION_BUN_STRING = "Onion Bun";
        public const string RYE_BUN_STRING = "Rye Bun";
        public const string WRAP_STRING = "Wrap";
        public const string VEGGIE_BURGER_STRING = "Veggie";
        public const string REGULAR_BURGER_STRING = "Regular";
        public const string LETTUCE_STRING = "Lettuce";
        public const string TOMATO_STRING = "Tomato";
        public const string ONION_STRING = "Onion";
        public const string PICKLES_STRING = "Pickles";
        public const string CHEESE_STRING = "Cheese";
        public const string BACON_STRING = "Bacon";

        public static BunType StrToBun(string s)
        {
            switch (s)
            {
                case RYE_BUN_STRING:
                    return BunType.RYE_BUN;
                case ONION_BUN_STRING:
                    return BunType.ONION_BUN;
                case WHITE_BUN_STRING:
                    return BunType.WHITE_BUN;
                case WRAP_STRING:
                    return BunType.WRAP;
            }

            return BunType.WHITE_BUN;
        }

        public static BurgerType StrToBurger(string s)
        {
            switch (s)
            {
                case REGULAR_BURGER_STRING:
                    return BurgerType.REGUALR;
                    
                case VEGGIE_BURGER_STRING:
                    return BurgerType.VEGGIE;
                   
            }

            return BurgerType.REGUALR;
        }
        public enum BunType
        {
            [Description(WHITE_BUN_STRING)]
            WHITE_BUN,
            [Description(ONION_BUN_STRING)]
            ONION_BUN,
            [Description(RYE_BUN_STRING)]
            RYE_BUN,
            [Description(WRAP_STRING)]
            WRAP

        }

        public enum BurgerType
        {
            [Description(VEGGIE_BURGER_STRING)]
            VEGGIE,
            [Description(REGULAR_BURGER_STRING)]
            REGUALR
        }

        public enum Toppings
        {
            [Description(LETTUCE_STRING)]
            LETTUCE,
            [Description(TOMATO_STRING)]
            TOMATO,
            [Description(ONION_STRING)]
            ONION,
            [Description(PICKLES_STRING)]
            PICKLES,
            [Description(CHEESE_STRING)]
            CHEESE,
            [Description(BACON_STRING)]
            BACON
        }
    }
    
    public class Burger
    {
        public  List<BurgerEnums.Toppings> ToppingsChoices { get; set; }
        public BurgerEnums.BunType Bun { get; set; }
        public BurgerEnums.BurgerType TypeOfBurger { get; set; }
        public int NumberOfBurgers { get; set; }
        public Guid BurgerId { get; set; }

        public Burger(BurgerEnums.BunType bun, BurgerEnums.BurgerType typeOfBurger, List<BurgerEnums.Toppings> burgerToppingsChoices, int numberOfBurgers)
        {
            Bun = bun;
            TypeOfBurger = typeOfBurger;
            ToppingsChoices = burgerToppingsChoices;
            NumberOfBurgers = numberOfBurgers;
            BurgerId = Guid.NewGuid();
        }

        public static float BurgerPrice(Burger b)
        {
            float price = 0f;
            b.ToppingsChoices.ForEach(toppings1 =>
            {
                switch (toppings1)
                {
                    case BurgerEnums.Toppings.LETTUCE:
                    case BurgerEnums.Toppings.CHEESE:
                    case BurgerEnums.Toppings.ONION:
                    case BurgerEnums.Toppings.PICKLES:
                    case BurgerEnums.Toppings.TOMATO:
                        break;
                    case BurgerEnums.Toppings.BACON:
                        price += 0.50f;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(toppings1), toppings1, null);
                }
            });
            switch (b.TypeOfBurger)
            {
                case BurgerEnums.BurgerType.VEGGIE:
                    price += 5.0f;
                    break;
                case BurgerEnums.BurgerType.REGUALR:
                    price += 5.0f;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            price *= b.NumberOfBurgers;
            return price;
        }
        

    }

    public class BurgerBuilder
    {
        public List<BurgerEnums.Toppings> ToppingsChoices { get; set; }
        private BurgerEnums.BunType Bun { get; set; }
        private BurgerEnums.BurgerType BurgerSelection { get; set; }
        private int NumberOfBurgers { get; set; }

        public BurgerBuilder BunChoice(BurgerEnums.BunType bun)
        {
            Bun = bun;
            return this;
        }

        public BurgerBuilder BurgerChoice(BurgerEnums.BurgerType burger)
        {
            BurgerSelection = burger;
            return this;
        }

        public BurgerBuilder BugerToppings(List<BurgerEnums.Toppings> toppings)
        {
            ToppingsChoices = toppings;
            return this;
        }

        public BurgerBuilder BurgerCount(int number)
        {
            NumberOfBurgers = number;
            return this;
        }

        public Burger Build()
        {
            return new Burger(Bun, BurgerSelection, ToppingsChoices, NumberOfBurgers);
        }
    }
}