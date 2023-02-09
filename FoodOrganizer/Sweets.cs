using System;
namespace FoodOrganizer
{
    public class Sweets : Makro
    {
        public string Nazwa { set; get; }
        public int Ilosc { set; get; }
        public string DataWaznosci { set; get; }

        public Sweets(string nazwa, int ilosc, string datawaznosci, decimal fat, decimal carbs, decimal sugar, decimal protein) : base(fat, carbs, sugar, protein)
        {
            this.Nazwa = nazwa;
            this.Ilosc = ilosc;
            this.DataWaznosci = datawaznosci;
        }
        public new string Info()
        {
            return string.Format("{0}, w ilości: {1}, data ważności: {2}. {3}", Nazwa, Ilosc, DataWaznosci, base.Info());
        }
    }
}
