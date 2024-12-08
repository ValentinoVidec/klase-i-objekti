using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace ZrakoplovApp
            { 
    
        public class Zrakoplov
        {
            private string naziv;
            private double snagaMotora;
            private int dosegLeta;
            public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
            {
                this.naziv = naziv;
                this.snagaMotora = snagaMotora;
                this.dosegLeta = dosegLeta;
            }

            public override string ToString()
            {
                return $"Naziv: {naziv}, Snaga motora: {snagaMotora} kW, Doseg leta: {dosegLeta} km";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
                Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
                Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

                Console.WriteLine(x380.ToString());
                Console.WriteLine(C162.ToString());
                Console.WriteLine(PC21.ToString());

                Console.ReadLine();
            }
        }
    }
}    

