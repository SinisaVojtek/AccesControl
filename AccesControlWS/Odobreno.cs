using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    class Odobreno : RazinaPristupa
    {
        public Odobreno(RazinaPristupa razina) : this(razina.podaci, razina.Pristup)
        {

        }

        public Odobreno(string podaci, Pristup razina)
        {
            this.Pristup = razina;
            this.podaci = podaci;
        }

        public override string pristup()
        {
            promijeniStatus();
            return ("Traženi podaci: "+ podaci);
        }
        
        private void promijeniStatus()
        {
            Pristup.trenutniStatus = new Pročitano(this);
        }
    }
}
