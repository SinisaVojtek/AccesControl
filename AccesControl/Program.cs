using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControl
{
    class Program
    {
        public enum ACCESS
        {
            ODOBRENO,
            ZABRANJENO,
            PROČITANO
        }

        private ACCESS trenutniStatus = ACCESS.ZABRANJENO;
        private string podaci = "Povjerljivi podaci: asdkfdčajklgačjksdčfjačk";

        public string pristup()
        {
            switch (trenutniStatus)
            {
                case ACCESS.ZABRANJENO:
                    return provjeraKorisničkihPodataka();
                case ACCESS.ODOBRENO:
                    return citajPodatak();
                case ACCESS.PROČITANO:
                    return izlaz();
                 
            }
            return string.Empty;
        }

        private string provjeraKorisničkihPodataka()
        {
            Console.WriteLine("Za pristup podacima unesite vaš username: ");
            string username = Console.ReadLine();

            if(username.Trim()=="Sinisa")
            {
                trenutniStatus = ACCESS.ODOBRENO;
                return ("pristup odobren!");
            }

            return "Pristup nije dozvoljen.";
        }

        public string citajPodatak()
        {
            trenutniStatus = ACCESS.PROČITANO;
            return podaci;
        }

        public string izlaz()
        {
            trenutniStatus = ACCESS.ZABRANJENO;
            return string.Format("Podatke ste pročitali, odlogirani ste iz sustava.");
        }


        static void Main(string[] args)
        {
            Program p = new AccesControl.Program();

            while (true)
            {
                Console.WriteLine(p.pristup());
            }
        }
    }
}
