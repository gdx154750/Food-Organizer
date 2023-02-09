using System;
namespace FoodOrganizer
{
    public class Drinks : Makro
    {
        public string Nazwa { set; get; }
        public decimal Pojemnosc { set; get; }
        public string DataWaznosci { set; get; }

        public Drinks(string nazwa, decimal pojemnosc, string datawaznosci, decimal fat, decimal carbs, decimal sugar, decimal protein) : base(fat, carbs, sugar, protein)
        {
            this.Nazwa = nazwa;
            this.Pojemnosc = pojemnosc;
            this.DataWaznosci = datawaznosci;
        }
        public new string Info()
        {
            return string.Format("{0}, {1}[l], data ważności: {2}. {3}", Nazwa, Pojemnosc, DataWaznosci, base.Info());
        }
    }
}
