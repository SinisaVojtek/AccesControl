using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    class Zabranjeno: RazinaPristupa
    {
        public Zabranjeno(RazinaPristupa razina):this(razina.Pristup)
        {

        }

        public Zabranjeno(Pristup razina)
        {
            this.Pristup = razina;
        }

        public override string pristup()
        {
            Console.WriteLine("Za pristup podacima unesite vaš username: ");
            string username = Console.ReadLine();

            if (username.Trim() == "Sinisa")
            {
                promijeniStatus();
                return ("pristup odobren!");
            }

            return "Pristup nije dozvoljen.";
        }

        private void promijeniStatus()
        {
            Pristup.trenutniStatus = new Odobreno(this);
        }
    }
}
