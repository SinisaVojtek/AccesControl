using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    class Zabranjeno: RazinaPristupa
    {
        public Zabranjeno(RazinaPristupa razina) : this(razina.podaci, razina.Pristup)
        {

        }

        public Zabranjeno(string podaci, Pristup razina)
        {
            this.Pristup = razina;
            this.podaci = podaci;
        }

        public override string pristup()
        {
            Console.WriteLine("Za pristup podacima unesite vaš username: ");
            string username = Console.ReadLine();

           
            if(promijeniStatus(username.Trim()))
                return ("pristup odobren!");
         

            return "Pristup nije dozvoljen.";
        }

        private bool promijeniStatus(string username)
        {
            if (username == "Sinisa")
            {
                Pristup.trenutniStatus = new Odobreno(this);
                return true;
            }
            else if (username == "Damir")
            {
                Pristup.trenutniStatus = new Promjeni(this);
                return true;
            }
            return false;
        }
    }
}
