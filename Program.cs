using ejednevn1k;
using System;

namespace ejednevn1k
{
    internal class Program
    {
        internal void Main(string[] args)
        {
            int q = 5;

            DateTime date = new DateTime(2022, 10, 26);
            dnik zantka = new dnik();
            zamtka name = "мувы";
            zamtka data = new DateTime(2022, 19, 26);
            zamtka telo = "gogo";
            dnik zantka1 = new dnik();
            zamtkal name = "парик";
            zamtkal data = new DateTime(2022, 10, 26);
            zamtkal telo = "France";
            dnik zantka2 = new dnik();
            zamtka2.name = "Музы";
            zamtka2 data = new DateTime(2022, 16, 24);
            zamtka2 telo = "луи";
            dnik zantka3 = new dnik();
            zamtka3.name = "Сходить туда";
            zamtka3 data = new DateTime(2022, 10, 27);
            zamtka3 telo = "хочу";

            List<dnik> dniks = new List<dnik>();
            dniks.Add(zantka);
            dniks.Add(zantka1);
        }
    }
}