using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_1
{
    class Adress
    {
        public string Gorod { get; set; }
        public string Ulica { get; set; }
        public int NomDoma { get; set; }
        public Adress()
        {
            
        }
        public Adress(string gorod, string ulica, int nomDoma)
        {
            Gorod = gorod;
            Ulica = ulica;
            NomDoma = nomDoma;
        }
        public void setGorod(string gorod)
        {
            Gorod = gorod;
        }
        public string getGorod()
        {
            return Gorod;
        }
        public void setUlica(string ulica)
        {
            Ulica = ulica;
        }
        public string getUlica()
        {
            return Ulica;
        }
        public void setNomDoma(string nomDoma)
        {
            NomDoma = Convert.ToInt32(nomDoma);
        }
        public int getNomDoma()
        {
            return NomDoma;
        }
        public void ToString()
        {
            Console.Clear();
            Console.WriteLine("Город: " + Gorod + ", Улица: " + Ulica + ", Номер дома: " + NomDoma);
        }

    }
}
