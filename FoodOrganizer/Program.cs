using System;
using System.Collections.Generic;

namespace FoodOrganizer
{
    class MainClass
    {
        public static MeatAndDairy DodajMeatAndDairy()
        {
            Console.WriteLine("Podaj nazwę produktu: ");
            string nazwa = Console.ReadLine();
            decimal masa;
            do
            {
                Console.WriteLine("Podaj masę produktu w gramach: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out masa));

            Console.WriteLine("Podaj datę ważności produktu: ");
            string datawaznosci = Console.ReadLine();

            Console.WriteLine("Podaj makro produktu:");

            decimal fat;
            do
            {
                Console.WriteLine("Tłuszcz: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out fat));

            decimal carbs;
            do
            {
                Console.WriteLine("Węglowodany: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out carbs));

            decimal sugar;
            do
            {
                Console.WriteLine("Cukier: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out sugar));

            decimal protein;
            do
            {
                Console.WriteLine("Białko: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out protein));

            return new MeatAndDairy(nazwa, masa, datawaznosci, fat, carbs, sugar, protein);

    }

        public static VegetablesAndFruits DodajVegetablesAndFruits()
        {
            Console.WriteLine("Podaj nazwę produktu: ");
            string nazwa = Console.ReadLine();
            int ilosc;
            do
            {
                Console.WriteLine("Podaj ilość: ");
            }
            while (!int.TryParse(Console.ReadLine(), out ilosc));

            Console.WriteLine("Podaj makro produktu:");

            decimal fat;
            do
            {
                Console.WriteLine("Tłuszcz: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out fat));

            decimal carbs;
            do
            {
                Console.WriteLine("Węglowodany: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out carbs));

            decimal sugar;
            do
            {
                Console.WriteLine("Cukier: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out sugar));

            decimal protein;
            do
            {
                Console.WriteLine("Białko: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out protein));

            return new VegetablesAndFruits(nazwa, ilosc, fat, carbs, sugar, protein);

        }

        public static Cereals DodajCereals()
        {
            Console.WriteLine("Podaj nazwę produktu: ");
            string nazwa = Console.ReadLine();
            decimal masa;
            do
            {
                Console.WriteLine("Podaj masę produktu w gramach: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out masa));

            Console.WriteLine("Podaj datę ważności produktu: ");
            string datawaznosci = Console.ReadLine();

            Console.WriteLine("Podaj makro produktu:");

            decimal fat;
            do
            {
                Console.WriteLine("Tłuszcz: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out fat));

            decimal carbs;
            do
            {
                Console.WriteLine("Węglowodany: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out carbs));

            decimal sugar;
            do
            {
                Console.WriteLine("Cukier: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out sugar));

            decimal protein;
            do
            {
                Console.WriteLine("Białko: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out protein));

            return new Cereals(nazwa, masa, datawaznosci, fat, carbs, sugar, protein);

        }

        public static Drinks DodajDrinks()
        {
            Console.WriteLine("Podaj nazwę produktu: ");
            string nazwa = Console.ReadLine();
            decimal pojemnosc;
            do
            {
                Console.WriteLine("Podaj pojemność produktu w litrach: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out pojemnosc));

            Console.WriteLine("Podaj datę ważności produktu: ");
            string datawaznosci = Console.ReadLine();

            Console.WriteLine("Podaj makro produktu:");

            decimal fat;
            do
            {
                Console.WriteLine("Tłuszcz: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out fat));

            decimal carbs;
            do
            {
                Console.WriteLine("Węglowodany: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out carbs));

            decimal sugar;
            do
            {
                Console.WriteLine("Cukier: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out sugar));

            decimal protein;
            do
            {
                Console.WriteLine("Białko: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out protein));

            return new Drinks(nazwa, pojemnosc, datawaznosci, fat, carbs, sugar, protein);

        }

        public static Sweets DodajSweets()
        {
            Console.WriteLine("Podaj nazwę produktu: ");
            string nazwa = Console.ReadLine();
            int ilosc;
            do
            {
                Console.WriteLine("Podaj ilość: ");
            }
            while (!int.TryParse(Console.ReadLine(), out ilosc));

            Console.WriteLine("Podaj datę ważności produktu: ");
            string datawaznosci = Console.ReadLine();

            Console.WriteLine("Podaj makro produktu:");

            decimal fat;
            do
            {
                Console.WriteLine("Tłuszcz: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out fat));

            decimal carbs;
            do
            {
                Console.WriteLine("Węglowodany: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out carbs));

            decimal sugar;
            do
            {
                Console.WriteLine("Cukier: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out sugar));

            decimal protein;
            do
            {
                Console.WriteLine("Białko: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out protein));

            return new Sweets(nazwa, ilosc, datawaznosci, fat, carbs, sugar, protein);

        }

        public static void WypiszMeatAndDairy(List<MeatAndDairy> meatAndDairy)
        {
            Console.Clear();
            for (int i = 1; i <= meatAndDairy.Count; i++)
            {
                Console.WriteLine("{0,3}. {1}", i, meatAndDairy[i - 1]);
                if (i % Console.WindowHeight == 0) Console.ReadKey(false);
            }
            Console.ReadKey();
        }

        public static void WypiszVegetablesAndFruits(List<VegetablesAndFruits> vegetablesAndFruits)
        {
            Console.Clear();
            for (int i = 1; i <= vegetablesAndFruits.Count; i++)
            {
                Console.WriteLine("{0,3}. {1}", i, vegetablesAndFruits[i - 1]);
                if (i % Console.WindowHeight == 0) Console.ReadKey(false);
            }
            Console.ReadKey();
        }

        public static void WypiszCereals(List<Cereals> cereals)
        {
            Console.Clear();
            for (int i = 1; i <= cereals.Count; i++)
            {
                Console.WriteLine("{0,3}. {1}", i, cereals[i - 1]);
                if (i % Console.WindowHeight == 0) Console.ReadKey(false);
            }
            Console.ReadKey();
        }

        public static void WypiszDrinks(List<Drinks> drinks)
        {
            Console.Clear();
            for (int i = 1; i <= drinks.Count; i++)
            {
                Console.WriteLine("{0,3}. {1}", i, drinks[i - 1]);
                if (i % Console.WindowHeight == 0) Console.ReadKey(false);
            }
            Console.ReadKey();
        }

        public static void WypiszSweets(List<Sweets> sweets)
        {
            Console.Clear();
            for (int i = 1; i <= sweets.Count; i++)
            {
                Console.WriteLine("{0,3}. {1}", i, sweets[i - 1]);
                if (i % Console.WindowHeight == 0) Console.ReadKey(false);
            }
            Console.ReadKey();
        }

        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("A - Dodaj nowy produkt");
            Console.WriteLine("B - Usuń produkt z listy");
            Console.WriteLine("C - Wyświetl listę");
            Console.WriteLine("K - Koniec");
            return Console.ReadKey().KeyChar;
        }

        static char Produkty()
        {
            Console.Clear();
            Console.WriteLine("A - Mięso i nabiał");
            Console.WriteLine("B - Warzywa i owoce");
            Console.WriteLine("C - Produkty zbożowe");
            Console.WriteLine("D - Napoje");
            Console.WriteLine("E - Słodycze");
            Console.WriteLine("K - Koniec");
            return Console.ReadKey().KeyChar;
        }

        static void Main(string[] args)
        {
            List<MeatAndDairy> mad = new List<MeatAndDairy>(100);
            List<VegetablesAndFruits> vaf = new List<VegetablesAndFruits>(100);
            List<Cereals> cereals = new List<Cereals>(100);
            List<Drinks> drinks = new List<Drinks>(100);
            List<Sweets> sweets = new List<Sweets>(100);

            char m;
            char produkty;
            do {
                m = Menu();
                switch (m)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Z jakiej kategorii?");
                        produkty = Produkty();
                        switch(produkty)
                        {
                            case 'a':
                            case 'A':
                                mad.Add(DodajMeatAndDairy());
                                    break;
                            case 'b':
                            case 'B':
                                vaf.Add(DodajVegetablesAndFruits());
                                break;
                            case 'c':
                            case 'C':
                                cereals.Add(DodajCereals());
                                break;
                            case 'd':
                            case 'D':
                                drinks.Add(DodajDrinks());
                                break;
                            case 'e':
                            case 'E':
                                sweets.Add(DodajSweets());
                                break;
                        }
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("Z jakiej kategorii?");
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Z jakiej kategorii?");
                        produkty = Produkty();
                        switch (produkty)
                        {
                            case 'a':
                            case 'A':
                                WypiszMeatAndDairy(mad);
                                break;
                            case 'b':
                            case 'B':
                                WypiszVegetablesAndFruits(vaf);
                                break;
                            case 'c':
                            case 'C':
                                WypiszCereals(cereals);
                                break;
                            case 'd':
                            case 'D':
                                WypiszDrinks(drinks);
                                break;
                            case 'e':
                            case 'E':
                                WypiszSweets(sweets);
                                break;
                        }
                        break;
                }

            } while (!(m == 'k' || m == 'K'));
    }
   }
}

