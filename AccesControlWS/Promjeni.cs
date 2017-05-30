using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    class Promjeni: RazinaPristupa
    {
        public Promjeni(RazinaPristupa razina) : this(razina.podaci, razina.Pristup)
        {

        }

        public Promjeni(string podaci, Pristup razina)
        {
            this.Pristup = razina;
            this.podaci = podaci;
        }


        public override string pristup()
        {
            Console.WriteLine("Traženi podaci: "+podaci);
            Console.WriteLine("Želite izmjeniti podatke? DA ili NE");
            string odgovor = Console.ReadLine();

            if (odgovor == "DA")
            {
                Console.WriteLine("Unesite izmjene:");
                podaci = Console.ReadLine();
                Console.WriteLine("Podaci uspješno izmjenjeni, nova vrijednost:");
            }
            promijeniStatus();
            return ("Traženi podaci: "+ podaci);
        }

        private void promijeniStatus()
        {
            Pristup.trenutniStatus = new Pročitano(this);
        }
    }
}

